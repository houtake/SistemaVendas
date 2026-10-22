using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaVendas.modelos;

namespace SistemaVendas.DAO
{
    public class CategoriaDAO
    {
        private Conexao banco = new Conexao();

        public void Inserir(Categoria categoria)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;
                string query = "INSERT INTO Categoria (Nome) VALUES (@Nome)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", categoria.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Alterar(Categoria categoria)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;
                string query = "UPDATE Categoria SET Nome = @Nome WHERE Id = @IdCategoria";
                //atualiza o nome para oq tiver em @nome somente onde o id for igual
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", categoria.Nome);
                    cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable ListarTodas()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return tabela;

                string sql = "SELECT * FROM Categoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // O SqlDataAdapter pega o resultado do SELECT e preenche o DataTable
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }
            return tabela;
        }
        public Categoria ConsultarPorId(int idCategoria)
        {
            Categoria categoriaEncontrada = null; // Começa vazio

            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return null;

                string sql = "SELECT * FROM Categoria WHERE IdCategoria = @IdCategoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    // O SqlDataReader serve para ler o resultado linha por linha
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read()) // Se ele conseguiu ler, é porque o registro existe!
                        {
                            categoriaEncontrada = new Categoria();
                            categoriaEncontrada.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                            categoriaEncontrada.Nome = dr["Nome"].ToString();
                        }
                    }
                }
            }
            return categoriaEncontrada;
        }
        public void Excluir(int idCategoria)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = "DELETE FROM Categoria WHERE IdCategoria = @IdCategoria";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
