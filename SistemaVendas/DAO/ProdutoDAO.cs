using SistemaVendas.modelos;
using System;
using Microsoft.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class ProdutoDAO
    {
        private Conexao banco = new Conexao();

        // 1. INSERIR
        public void Inserir(Produto produto)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = "INSERT INTO Produto (Nome, Preco, IdCategoria) VALUES (@Nome, @Preco, @IdCategoria)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@IdCategoria", produto.IdCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. ALTERAR
        public void Alterar(Produto produto)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = "UPDATE Produto SET Nome = @Nome, Preco = @Preco, IdCategoria = @IdCategoria WHERE IdProduto = @IdProduto";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@IdCategoria", produto.IdCategoria);
                    cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. EXCLUIR
        public void Excluir(int idProduto)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = "DELETE FROM Produto WHERE IdProduto = @IdProduto";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. CONSULTAR POR ID
        public Produto ConsultarPorId(int idProduto)
        {
            Produto produtoEncontrado = null;

            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return null;

                string sql = "SELECT * FROM Produto WHERE IdProduto = @IdProduto";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProduto", idProduto);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            produtoEncontrado = new Produto();
                            produtoEncontrado.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                            produtoEncontrado.Nome = dr["Nome"].ToString();
                            produtoEncontrado.Preco = Convert.ToDecimal(dr["Preco"]);
                            produtoEncontrado.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                        }
                    }
                }
            }
            return produtoEncontrado;
        }
    }
}