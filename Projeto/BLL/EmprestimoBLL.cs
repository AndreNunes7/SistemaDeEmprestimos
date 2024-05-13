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

        public static bool ValidarUsuario(Usuario usuario)
        {
            Erro.setErro(false);

            
            if (string.IsNullOrEmpty(usuario.nome))
            {
                Erro.setMsg("Por favor, insira um nome de usuário.");
                return false;
            }

           
            if (string.IsNullOrEmpty(usuario.senha))
            {
                Erro.setMsg("Por favor, insira uma senha.");
                return false;
            }

            
            if (EmprestimoDAL.GetUser(usuario))
            {
                
                return true;
            }
            else
            {
               
                Erro.setMsg("Nome de usuário ou senha incorretos.");
                return false;
            }
        }
    }
}
