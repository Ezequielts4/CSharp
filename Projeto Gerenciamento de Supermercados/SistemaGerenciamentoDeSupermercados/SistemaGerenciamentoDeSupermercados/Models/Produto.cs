using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Produto
    {
        public int IdP { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int DataDeValidade { get; set; }
    }
}

