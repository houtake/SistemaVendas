using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace SistemaVendas.DAO
{
    public class Conexao
    {
        private readonly string stringConexao = @"Data Source=localhost;Initial Catalog=SistemaVendas;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(stringConexao);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message,
                                "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}