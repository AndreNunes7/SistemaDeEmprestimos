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
    public partial class AtualizarSenha : Form
    {
        public AtualizarSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //aqui estamos atualizando a senha do usuario e usando o metodo de atualizar senha na bll para alterar no banco de dados

            /*string nomeUsuario = txtUsuario.Text;
            novaSenha = txtNovaSenha.Text;

            // Atualizar a senha no banco de dados
            bll.AtualizarSenha(nomeUsuario, novaSenha);*/

            this.DialogResult = DialogResult.OK;

        }

        private void lbLimpar_Click(object sender, EventArgs e)
        {
            txtConfirmarSenha.Text = string.Empty;
            txtPrimeiraSenha.Text = string.Empty;
        }
    }
}
