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

        private static string strConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BancoDeDados.accdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        

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

        public static bool PostUser(Usuario usuario)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(strConexao))
                {
                    conn.Open();
                    string sql = $"INSERT INTO Usuarios (Nome, Senha) VALUES ('{usuario.nome}', '{usuario.senha}')";
                    OleDbCommand strSQL = new OleDbCommand(sql, conn);
                    strSQL.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir usuário no banco de dados: {ex.Message}");
                return false;
            }
        }

        public static bool GetUser(Usuario usuario)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(strConexao))
                {
                    conn.Open();
                    string sql = "SELECT Nome, Senha FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
                    OleDbCommand command = new OleDbCommand(sql, conn);
                    command.Parameters.AddWithValue("@Nome", usuario.nome);
                    command.Parameters.AddWithValue("@Senha", usuario.senha);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar usuário no banco de dados: {ex.Message}");
                return false;
            }
        }
    }
}