using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public abstract class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public int NumeroDeRegistro { get; set; }
        public int HorarioDeTrabalho { get; set; }

        public override void Atualizar()
        {
            Console.Write("Insira o novo nome: ");
            Cargo = Console.ReadLine();

            Console.Write("Insira o número de registro: ");
            NumeroDeRegistro = int.Parse(Console.ReadLine());

            Console.Write("Insira o novo horário de trabalho: ");
            HorarioDeTrabalho = int.Parse(Console.ReadLine());
        }
    }
}
