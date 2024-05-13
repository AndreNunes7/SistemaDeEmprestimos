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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            PreencherListBox();
        }

        private void PreencherListBox()
        {
            // Limpa o ListBox antes de preencher novamente
            listBox1.Items.Clear();

            // Aqui você deve obter os registros do banco de dados
            //List<string> registros = DataAccess.ObterRegistros();

            // Adiciona os registros ao ListBox
            //foreach (string registro in registros)
            //{
            //    listBox1.Items.Add(registro);
            //}
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PreencherListBox();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
