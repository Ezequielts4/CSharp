using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public abstract void Atualizar();
        public abstract void MostrarDetalhes();
    }
}