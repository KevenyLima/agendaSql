using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace WindowsFormsApp1
{
    public partial class adicionar_cliente : Form
    {
        int id;
        public bool editar;
        public adicionar_cliente()
        {
            InitializeComponent();
           
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "DATA source = " + sql_funcoes.base_dados;
            ligacao.Open();
            if (editar == false)
            {

                if (text_endereco.Text == "" || text_nome.Text == "" || text_numero.Text == "")
                {
                    MessageBox.Show("Os campos não foram preenchidos corretamente");
                    return;
                }
                SqlCeCommand operario = new SqlCeCommand();
                operario.Connection = ligacao;
                operario.Parameters.AddWithValue("@id", id);
                operario.Parameters.AddWithValue("@nome", text_nome.Text);
                operario.Parameters.AddWithValue("@endereco", text_endereco.Text);
                operario.Parameters.AddWithValue("@numero", text_numero.Text);

                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                DataTable data = new DataTable();
                operario.CommandText = "SELECT * FROM clientes WHERE nome = @nome AND numero = @numero";
                adapter.SelectCommand = operario;
                adapter.Fill(data);
                if (data.Rows.Count != 0)
                {

                    MessageBox.Show("este registro já existe");
                    return;
                }
                    operario.CommandText = "INSERT INTO clientes VALUES(@id,@nome,@numero,@endereco)";
                    operario.ExecuteNonQuery();
                    operario.Dispose();
            }
            else
            {
                SqlCeCommand operario = new SqlCeCommand();
                operario.Connection = ligacao;
                operario.Parameters.AddWithValue("@id",lista_clientes.id_clientes);
                operario.Parameters.AddWithValue("@nome", text_nome.Text);
                operario.Parameters.AddWithValue("@endereco", text_endereco.Text);
                operario.Parameters.AddWithValue("@numero", text_numero.Text);

                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                DataTable dados = new DataTable();
                operario.CommandText = "SELECT * FROM clientes WHERE nome = @nome AND id_clientes <> @id";
                adapter.SelectCommand = operario;
                adapter.Fill(dados);
                if (dados.Rows.Count != 0)
                {

                    if(MessageBox.Show("ja existe um um cliente com mesmo nome deseja continua?", "Confirmar ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    

                }
                operario.CommandText = "UPDATE clientes SET nome = @nome, numero= @numero, endereço= @endereco WHERE id_clientes = @id";
                operario.ExecuteNonQuery();

            }
            ligacao.Dispose();
            editar = false;
            this.Close();
            
        }

        private void adicionar_cliente_Load(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = ("DATA source = " + sql_funcoes.base_dados);
            ligacao.Open();
            SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT MAX(id_clientes) AS maxid FROM clientes",ligacao);
            DataTable dados = new DataTable();
            operario.Fill(dados);
            if (!DBNull.Value.Equals(dados.Rows[0][0]))
            {
                id = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }
            else { id = 0; }
            

            if (editar == true)
            {
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM clientes WHERE id_clientes = " + lista_clientes.id_clientes, ligacao);
                dados = new DataTable();
                adaptador.Fill(dados);
                text_nome.Text = dados.Rows[0]["nome"].ToString();
                text_endereco.Text = dados.Rows[0]["endereço"].ToString();
                text_numero.Text = dados.Rows[0]["numero"].ToString();
            }
            ligacao.Dispose();

        }
    }
}
