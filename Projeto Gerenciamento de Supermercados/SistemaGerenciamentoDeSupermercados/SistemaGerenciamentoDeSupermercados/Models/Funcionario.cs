using SistemaGerenciamentoDeSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public int NumeroDeRegistro { get; set; }
        public string HorarioDeTrabalho { get; set; }

        public Funcionario(string nome, string cargo, int numeroRegistro, string horario)
        {
            this.Nome = nome;
            this.Cargo = cargo;
            this.NumeroDeRegistro = numeroRegistro;
            this.HorarioDeTrabalho = horario;
        }
        public Funcionario() { }

        public static Funcionario CriarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Preencha as informações abaixo para cadastrar um funcionário   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            Console.Write("Insira o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Insira o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Insira o número de registro: ");
            funcionario.NumeroDeRegistro = int.Parse(Console.ReadLine());

            Console.Write("Insira o horário de trabalho: ");
            funcionario.HorarioDeTrabalho = Console.ReadLine();

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Cadastrando um novo funcionário", 1000, 3, "VERDE");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nFuncionário adicionado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            return funcionario;
        }

        public override void Atualizar()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Atualize os dados do funcionário abaixo   ");
            Console.ResetColor();

            Console.WriteLine(); // para pular uma linha
            Console.Write("Atualize o nome: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize o cargo: ");
            Cargo = Console.ReadLine();

            Console.Write("Atualize o número de registro: ");
            NumeroDeRegistro = int.Parse(Console.ReadLine());

            Console.Write("Atualize o horário de trabalho: ");
            HorarioDeTrabalho = Console.ReadLine();

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Atualizando dados", 1000, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nFuncionário atualizado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nCargo: {Cargo}\nNúmero de registro: {NumeroDeRegistro}\nHorário de Trabalho: {HorarioDeTrabalho} horas");
        }
    }
}