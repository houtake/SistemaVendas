using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVendas.modelos
{
    public class Produto
    {
        public int IdProduto {get;set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int IdCategoria { get; set; }
    }
}
