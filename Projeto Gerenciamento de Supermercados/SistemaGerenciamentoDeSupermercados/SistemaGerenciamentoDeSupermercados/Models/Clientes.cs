using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Clientes : Pessoa
    {
        public string DataDeNascimento { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
    }
}
