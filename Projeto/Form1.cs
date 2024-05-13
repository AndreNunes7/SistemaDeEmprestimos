using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
        
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
        
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
        
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
        public Form1()
        {
            InitializeComponent();
            
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());

=======
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
            EmprestimoBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string senha = textBox2.Text;
<<<<<<< HEAD
<<<<<<< HEAD
            Usuario usuario = new Usuario() { nome = nome, senha = senha };

<<<<<<< HEAD
            if (EmprestimoBLL.ValidarUsuario(usuario))
=======
=======

>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======

>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
            Usuario usuario = new Usuario();
            usuario.nome = nome;
            usuario.senha = senha;

            
            if (EmprestimoBLL.validaUserBD(usuario))
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
            {
                Solicitar_emprestimo formEmprestimo = new Solicitar_emprestimo();
                MessageBox.Show("Usuario logado com sucesso!!");
                formEmprestimo.ShowDialog();
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                MessageBox.Show(Erro.getMsg());
=======
                MessageBox.Show("Login inválido!!");
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
                MessageBox.Show("Login inválido!!");
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
                MessageBox.Show("Login inválido!!");
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //aqui temos que criar uma maneira de verificar se o usuario existe e criarmos um novo form para ser onde ira atualizar a senha


            //string nome = txtUsuario.Text;

            //if (bll.ValidarUsuario(nome, string.Empty))
            //{
            AtualizarSenha formAtualizarSenha = new AtualizarSenha();
            formAtualizarSenha.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário não encontrado!");
            //}*/

        }
        //propriedades para armazenar o valor digitado no form de criar usuario
        public string NomeUsuario { get; private set; }
        public string Senha { get; private set; }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CriarUsuario formCriarUsuario = new CriarUsuario();
            formCriarUsuario.ShowDialog();

            /* NomeUsuario = txtUsuario.Text;
                Senha = txtSenha.Text;

                this.DialogResult = DialogResult.OK;
             }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Close();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        
=======
<<<<<<< HEAD
            Close();
        }

=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        
=======
            this.Close();
        }
>>>>>>> c6040666e318952654febff8bb0a60f4cf8934c0
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
=======
>>>>>>> a866bd5c167e6aa483227be7a98bc64d93dc33e1
    }
}



