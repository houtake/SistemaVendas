using SistemaVendas.modelos;
using System;
using Microsoft.Data.SqlClient;
using SistemaVendas.Models;

namespace SistemaVendas.DAO
{
    public class ClienteDAO
    {
        private Conexao banco = new Conexao();

        // 1. INSERIR
        public void Inserir(Cliente cliente)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = @"INSERT INTO Cliente (Nome, CPF, RG, UfRg, Rua, Numero, Complemento, Bairro, Cidade, CEP, UF, Telefone, Status, LimiteCredito) 
                               VALUES (@Nome, @CPF, @RG, @UfRg, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @CEP, @UF, @Telefone, @Status, @LimiteCredito)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    //caso o valor seja nulo usa o da direita com o ??
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@RG", cliente.RG ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UfRg", cliente.UfRg ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Rua", cliente.Rua ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Numero", cliente.Numero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CEP", cliente.CEP ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UF", cliente.UF ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", cliente.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LimiteCredito", cliente.LimiteCredito);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. ALTERAR
        public void Alterar(Cliente cliente)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = @"UPDATE Cliente SET 
                               Nome = @Nome, CPF = @CPF, RG = @RG, UfRg = @UfRg, Rua = @Rua, Numero = @Numero, 
                               Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, CEP = @CEP, 
                               UF = @UF, Telefone = @Telefone, Status = @Status, LimiteCredito = @LimiteCredito 
                               WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@RG", cliente.RG ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UfRg", cliente.UfRg ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Rua", cliente.Rua ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Numero", cliente.Numero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CEP", cliente.CEP ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UF", cliente.UF ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", cliente.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LimiteCredito", cliente.LimiteCredito);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. EXCLUIR
        public void Excluir(int idCliente)
        {
            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return;

                string sql = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. CONSULTAR POR ID
        public Cliente ConsultarPorId(int idCliente)
        {
            Cliente clienteEncontrado = null;

            using (SqlConnection conn = banco.Conectar())
            {
                if (conn == null) return null;

                string sql = "SELECT * FROM Cliente WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            clienteEncontrado = new Cliente();
                            clienteEncontrado.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                            clienteEncontrado.Nome = dr["Nome"].ToString();
                            clienteEncontrado.CPF = dr["CPF"].ToString();
                            clienteEncontrado.RG = dr["RG"].ToString();
                            clienteEncontrado.UfRg = dr["UfRg"].ToString();
                            clienteEncontrado.Rua = dr["Rua"].ToString();
                            clienteEncontrado.Numero = dr["Numero"].ToString();
                            clienteEncontrado.Complemento = dr["Complemento"].ToString();
                            clienteEncontrado.Bairro = dr["Bairro"].ToString();
                            clienteEncontrado.Cidade = dr["Cidade"].ToString();
                            clienteEncontrado.CEP = dr["CEP"].ToString();
                            clienteEncontrado.UF = dr["UF"].ToString();
                            clienteEncontrado.Telefone = dr["Telefone"].ToString();
                            clienteEncontrado.Status = dr["Status"].ToString();

                            // Verifica se o valor de limite de crédito não é nulo antes de converter
                            if (dr["LimiteCredito"] != DBNull.Value)
                                clienteEncontrado.LimiteCredito = Convert.ToDecimal(dr["LimiteCredito"]);
                            else
                                clienteEncontrado.LimiteCredito = 0;
                        }
                    }
                }
            }
            return clienteEncontrado;
        }
    }
}