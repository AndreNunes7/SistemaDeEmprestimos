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
    public partial class Solicitar_emprestimo : Form
    {
        public Solicitar_emprestimo()
        {
            InitializeComponent();
            
        }

       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*float valorEmprestimo;

            if (!float.TryParse(txtValorEmprestimo.Text, out valorEmprestimo))
            {
                MessageBox.Show("Por favor, digite um valor válido para o empréstimo.");
                return;
            }

            FormEscolherParcelas formParcelas = new FormEscolherParcelas(valorEmprestimo);
            if (formParcelas.ShowDialog() == DialogResult.OK)
            {
                // Aqui você pode receber os dados de parcelamento do formParcelas
                int quantidadeParcelas = formParcelas.QuantidadeParcelas;
                float valorParcela = formParcelas.ValorParcela;

                // Faça o que você precisar com os dados de parcelamento
                MessageBox.Show($"Você escolheu pagar em {quantidadeParcelas} vezes, com parcelas de R${valorParcela}.");
            }*/
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorEmprestimo.Text = string.Empty;
        }

        private void btnConsultarEmprestimos_Click(object sender, EventArgs e)
        {
             Consultar formConsultar = new Consultar();
             formConsultar.ShowDialog();
            
        }

        
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
           //botao para gerar relatorio word
            Button botaoWord = new Button();       
            botaoWord.Text = "Word";
            botaoWord.Size = new Size(100, 30);
            botaoWord.Location = new Point(680, 366);
            botaoWord.Click += new EventHandler(BotaoWord_Click);
            this.Controls.Add(botaoWord);
            botaoWord.BringToFront();
           //botao para gerar relatorio excel
            Button botaoExcel = new Button();
            botaoExcel.Text = "Excel";
            botaoExcel.Size = new Size(100, 30);
            botaoExcel.Location = new Point(680,318);

            this.Controls.Add(botaoExcel);
            botaoExcel.BringToFront();


        }


        
        private void BotaoWord_Click(object sender, EventArgs e)
        {
            

        }

        private void BotaoExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
