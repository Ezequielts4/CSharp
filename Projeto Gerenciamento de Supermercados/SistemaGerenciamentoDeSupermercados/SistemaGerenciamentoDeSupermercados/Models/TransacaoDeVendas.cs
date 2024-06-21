using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class TransacaoDeVendas
    {
        public int IdT { get; set; }
        public int IdDoCliente { get; set; }
        public int IdDoFuncionario { get; set; }
        public int DataTransacao { get; set; }
        public int HoraTransacao { get; set; }
        public string ListaDeProdutosComprados { get; set; }
        public int ValorTotal { get; set; }
    }
}
