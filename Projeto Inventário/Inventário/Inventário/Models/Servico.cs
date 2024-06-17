using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário.Models
{
    public class Servico : Item
    {
        public int DuracaoEmHoras { get; set; }
        public override void Atualizar()
        {
            Console.Write("Insira um novo nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira um novo preço: ");
            Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a nova duração em horas: ");
            DuracaoEmHoras = Convert.ToInt32(Console.ReadLine());
        }

        public static Servico CriarServico()
        {
            Servico servico = new Servico();

            Console.Write("Insira o nome: ");
            servico.Nome = Console.ReadLine();

            Console.Write("Insira o preço: ");
            servico.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a duração em horas: ");
            servico.DuracaoEmHoras = Convert.ToInt32(Console.ReadLine());

            return servico;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Serviço: {Nome}, Preço: {Preco:C}, Duração: {DuracaoEmHoras} horas");
        }
    }
}
