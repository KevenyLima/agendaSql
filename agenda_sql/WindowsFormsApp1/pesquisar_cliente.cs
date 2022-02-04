using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pesquisar_cliente : Form
    {
        
        public pesquisar_cliente()
        {
            InitializeComponent();
            
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_confirmar_Click(object sender, EventArgs e)
        {
            if (text_pesquisa.Text == "")
            {
                return;
            }
            else
            {
                lista_clientes lista_ = new lista_clientes();
                lista_.pesquisa = text_pesquisa.Text;
                this.Dispose();
                lista_.ShowDialog();
             
            }

        }
    }
}
