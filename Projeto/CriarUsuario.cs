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
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string repetirSenha = txtRepetirSenha.Text;

            if (senha != repetirSenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, digite novamente.");
                return;
            }

            // Verifica se o usuário já existe
            if (bll.ValidarUsuario(nomeUsuario, string.Empty))
            {
                MessageBox.Show("O usuário já existe. Por favor, escolha outro nome de usuário.");
                return;
            }

            // Insere o novo usuário no banco de dados
            bll.CriarNovoUsuario(nomeUsuario, senha);

            MessageBox.Show("Novo usuário criado com sucesso!");
            this.DialogResult = DialogResult.OK;*/
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtDigitarUsuario.Text = string.Empty;
            txtDigiteASenha.Text = string.Empty;
            txtCorfimarSenha.Text = string.Empty;
        }
    }
}
