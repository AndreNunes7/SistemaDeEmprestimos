using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class EmprestimoBLL
    {
        public static void conecta()
        {
            EmprestimoDAL.conecta();
        }
        public static void desconecta() 
        {
            EmprestimoDAL.desconecta();
        }

        public static void validaUsuario(Usuario usuario)
        {
            Erro.setErro(false);

            if (usuario.nome.Equals("") && usuario.senha.Equals(""))
            {
                Erro.setMsg("O nome e a senha devem ser preenchidos obrigatoriamente!!");
            }
            else if (usuario.nome.Equals(""))
            {
                Erro.setMsg("Voce deve inserir um login para entrar no sistema!");
            }
            else if (usuario.senha.Equals(""))
            {
                Erro.setMsg("Voce deve inserir uma senha para entrar no sistema!");
            }
            else
            {
                EmprestimoDAL.GetUser(usuario);
            }
        }

        public static bool validaUserBD(Usuario usuario)
        {
            Erro.setErro(false);

            if (!string.IsNullOrEmpty(usuario.nome) && !string.IsNullOrEmpty(usuario.senha))
            {
                
                bool usuarioExiste = EmprestimoDAL.GetUser(usuario);

                
                return usuarioExiste;
            }

           
            return false;
        }




    }
}
