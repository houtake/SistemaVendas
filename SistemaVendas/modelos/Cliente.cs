using System;
using System.Collections.Generic;
using System.Text;

    namespace SistemaVendas.Models
    {
        public class Cliente
        {
            public int IdCliente { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string RG { get; set; }
            public string UfRg { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }
            public string Telefone { get; set; }
            public string Status { get; set; }
            public decimal LimiteCredito { get; set; }
        }
    }
