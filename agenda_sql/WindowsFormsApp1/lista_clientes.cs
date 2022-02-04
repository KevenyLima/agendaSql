using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace WindowsFormsApp1
{
    public partial class lista_clientes : Form
    {
        public string pesquisa="";
        public static int id_clientes;
        public lista_clientes()
        {
            InitializeComponent();

        }
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Deseja mesmo apagar este cliente da lista?","Pedido de Comfirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
                sql_funcoes.deletar_dados();
                constroi_lista();
            }
            catch
            {
                MessageBox.Show("erro");  
            }
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            
            adicionar_cliente editar = new adicionar_cliente();
            editar.editar = true;
            editar.ShowDialog();
            constroi_lista();
        }

        private void lista_clientes_Load(object sender, EventArgs e)
        {
            constroi_lista();
        }
        private void constroi_lista()
        {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "DATA source=" + sql_funcoes.base_dados;
            ligacao.Open();
            
            if (pesquisa == "")
            {
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT *FROM clientes",ligacao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                grade_de_dados.DataSource = dados;
            }
            else
            {
                SqlCeCommand operario = new SqlCeCommand();
                operario.Connection = ligacao;
                operario.Parameters.AddWithValue("@termo", "%" + pesquisa + "%");
                operario.CommandText = "SELECT *FROM clientes WHERE nome LIKE @termo OR endereço LIKE @termo OR numero LIKE @termo";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = operario;
                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                grade_de_dados.DataSource = dados;
            }
            registros.Text ="Registros:" + grade_de_dados.Rows.Count;
            grade_de_dados.Columns["id_clientes"].Visible = false;
            grade_de_dados.Columns["nome"].Width = grade_dados(25);
            grade_de_dados.Columns["numero"].Width = grade_dados(20);
            grade_de_dados.Columns["endereço"].Width =grade_dados(55);
            cmd_editar.Enabled = false;
            cmd_apagar.Enabled = false;
        }

        private void grade_de_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          id_clientes=  Convert.ToInt16( grade_de_dados.Rows[e.RowIndex].Cells["id_clientes"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }
        private int grade_dados (int porcentagem)
        {
            int largura = grade_de_dados.Width - 60;
            int resultado = (largura * porcentagem) / 100;

            return resultado;
        }
    }
}
