using SistemaGerenciamentoDeSupermercados.Services;
using SistemaGerenciamentoDeSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Cliente : Pessoa
    {
        public ulong diaNascimento { get; set; }
        public ulong mesNascimento { get; set; }
        public ulong anoNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, ulong diaValidade, ulong mesValidade, ulong anoValidade, string endereco, string telefone)
        {
            this.Nome = nome;
            this.diaNascimento = diaValidade;
            this.mesNascimento = mesValidade;
            this.anoNascimento = anoValidade;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        public Cliente() { }

        public static Cliente CriarCliente()
        {
            Cliente cliente = new Cliente();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Preencha as informações abaixo para cadastrar um cliente   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            Console.Write("Insira o nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            string[] data = new string[3];
            Console.Write("Insira a data de nascimento (dd/mm/yyyy): ");
            data = Console.ReadLine().Split("/");

            cliente.diaNascimento = ulong.Parse(data[0]);
            cliente.mesNascimento = ulong.Parse(data[1]);
            cliente.anoNascimento = ulong.Parse(data[2]);

            Console.Write("Insira o endereço: ");
            cliente.Endereco = Console.ReadLine();

            Console.Write("Insira o telefone (apenas números): ");
            cliente.Telefone = Console.ReadLine();

            while (cliente.Telefone.Length != 11)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\nPor favor, insira o número de telefone com 11 digitos (apenas números):");
                Console.ResetColor();
                Console.Write("\n-> ");
                cliente.Telefone = Console.ReadLine();
            }

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Cadastrando um novo cliente", 1000, 3, "VERDE");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nCliente adicionado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return cliente;
        }

        public override void Atualizar()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Atualize os dados do cliente abaixo   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            Console.Write("Atualize o nome: ");
            Nome = Console.ReadLine();

            string[] data = new string[3];
            Console.Write("Atualize a data de nascimento (dd/mm/yyyy): ");
            data = Console.ReadLine().Split("/");

            diaNascimento = ulong.Parse(data[0]);
            mesNascimento = ulong.Parse(data[1]);
            anoNascimento = ulong.Parse(data[2]);

            Console.Write("Atualize o endereço: ");
            Endereco = Console.ReadLine();

            Console.Write("Atualize o telefone (apenas números): ");
            Telefone = Console.ReadLine();

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Atualizando dados", 1000, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nCliente atualizado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nData de nascimento: {diaNascimento}/{mesNascimento}/{anoNascimento}\nEndereço: {Endereco}\nTelefone: {long.Parse(Telefone).ToString(@"(00) 0 0000-0000")}");
        }
    }
}