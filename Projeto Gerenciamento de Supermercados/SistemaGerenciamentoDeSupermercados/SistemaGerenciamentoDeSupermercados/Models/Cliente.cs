using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Cliente : Pessoa
    {
        public string DataDeNascimento { get; set; }
        public string Endereco { get; set; }
        public float Telefone { get; set; }

        public static Cliente CriarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine(); // para pular uma linha
            Console.Write("Insira o nome ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Insira a data de nascimento: ");
            cliente.DataDeNascimento = Console.ReadLine();

            Console.Write("Insira o endereço: ");
            cliente.Endereco = Console.ReadLine();

            Console.Write("Insira o telefone: ");
            cliente.Telefone = float.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Cliente adicionado com sucesso!");

            return cliente;
        }
        public override void Atualizar()
        {
            Console.WriteLine(); // para pular uma linha
            Console.Write("Atualize o nome do cliente: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize a data de nascimento: ");
            DataDeNascimento = Console.ReadLine();

            Console.Write("Atualize o endereço: ");
            Endereco = Console.ReadLine();

            Console.Write("Atualize o telefone: ");
            Telefone = float.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Cliente atualizado com sucesso!");
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nData de nascimento: {DataDeNascimento}\nEndereço: {Endereco}\nTelefone: {Telefone}");
        }
    }
}
