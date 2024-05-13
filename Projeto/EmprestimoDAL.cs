using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projeto
{
    class EmprestimoDAL
    {

        private static string strConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProjetosC#\SistemaEmprestimo\BancoDeDados.accdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Erro ao se conectar ao banco de dados!");
            }
        }

        public static void desconecta()
        {
            conn.Close();

        }


        public static void PostUser(Usuario usuario)
        {

            try
            {
                string sql = $"INSERT INTO Usuarios (Nome, Senha) VALUES ('{usuario.nome}', '{usuario.senha}')";

                strSQL = new OleDbCommand(sql, conn);
                strSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro ao inserir usuário no banco de dados: {ex.Message}");

            }

        }

        public static bool GetUser(Usuario usuario)
        {
            using (OleDbConnection conn = new OleDbConnection(strConexao))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
                    OleDbCommand command = new OleDbCommand(sql, conn);
                    command.Parameters.AddWithValue("@Nome", usuario.nome);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string id = reader["ID"].ToString();
                            string nome = reader["Nome"].ToString();
                            string senha = reader["Senha"].ToString();

                            Usuario usuarioEncontrado = new Usuario();
                            usuarioEncontrado.ID = id;
                            usuarioEncontrado.nome = nome;
                            usuarioEncontrado.senha = senha;

                            MessageBox.Show($"Usuario {usuarioEncontrado.nome} logado com sucesso!");
                            return true;
                        }
                    }

                    MessageBox.Show("Usuario não encontrado!!");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar usuário no banco de dados: {ex.Message}");
                    return false;
                }
            }
        }
    }
}