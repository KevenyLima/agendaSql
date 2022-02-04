using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;

namespace WindowsFormsApp1
{
    static class  sql_funcoes
    {
        public static string base_dados;
        public static string pasta_dados;
        public static void deletar_dados() {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "DATA source=" + base_dados;
            ligacao.Open();
            SqlCeCommand operario = new SqlCeCommand("DELETE FROM clientes WHERE id_clientes=" + lista_clientes.id_clientes , ligacao);
            operario.ExecuteNonQuery();
            ligacao.Dispose();
        }
        public static void buscar_dados()
        {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = ("DATA source = " + base_dados );
            ligacao.Open();
            SqlCeCommand operario = new SqlCeCommand();
            operario.CommandText = "CREATE TABLE clientes(" +
                "id_clientes     int not null primary key," +
                "nome            nvarchar(30)," +
                "numero          nvarchar(20)," +
                "endereço        nvarchar(100))";
            operario.Connection = ligacao;
            operario.ExecuteNonQuery();
            operario.Dispose();
            ligacao.Dispose();
        }
        public static void inserir_dados(int id , string nome,string endereco,string numero)
        {
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "DATA source="+base_dados;
            ligacao.Open();
            SqlCeCommand operario = new SqlCeCommand();
            operario.Connection = ligacao;
            operario.Parameters.AddWithValue("@id", id);
            operario.Parameters.AddWithValue("@nome", nome);
            operario.Parameters.AddWithValue("@endereco", endereco);
            operario.Parameters.AddWithValue("@numero", numero);
            operario.CommandText = "INSERT INTO clientes VALUES(@id,@nome,@endereco,@numero)";
            operario.ExecuteNonQuery();                        
            ligacao.Close();                                   
            operario.Dispose();                                
        }
        public static void inicia_aplicacao()
        {
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\agendaSql";

            if (!Directory.Exists(pasta_dados))
            {
                Directory.CreateDirectory(pasta_dados);
            }
            
             base_dados = pasta_dados + "\\dados.sdf";
            if (!File.Exists(base_dados))
            {
                criar_base_dados();
            }
               
        }
        public static void criar_base_dados()
        {
            SqlCeEngine motor = new SqlCeEngine("DATA source = " + base_dados);
            motor.CreateDatabase();
            buscar_dados();
        }
    }
}
