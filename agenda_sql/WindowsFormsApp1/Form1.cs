using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da aplicaçao?", "SAIR DA APLICAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_cliente pesquisa = new pesquisar_cliente();
            pesquisa.ShowDialog();
        }

        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            adicionar_cliente adicionar = new adicionar_cliente();
            adicionar.ShowDialog();
        }

        private void cmd_mostra_tudo_Click(object sender, EventArgs e)
        {
            lista_clientes lista = new lista_clientes();
            lista.ShowDialog();
        }
    }
}
