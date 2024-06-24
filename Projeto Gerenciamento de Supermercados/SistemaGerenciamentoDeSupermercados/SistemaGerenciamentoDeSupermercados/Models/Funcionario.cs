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
        public int HorarioDeTrabalho { get; set; }

        public static Funcionario CriarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Insira o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Insira o cargo do funcionário: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Insira o número de registro: ");
            funcionario.NumeroDeRegistro = int.Parse(Console.ReadLine());

            Console.Write("Insira o horário de trabalho: ");
            funcionario.HorarioDeTrabalho = int.Parse(Console.ReadLine());

            return funcionario;
        }

        public override void Atualizar()
        {
            Console.Write("Atualize o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize o cargo do funcionário: ");
            Cargo = Console.ReadLine();

            Console.Write("Atualize o número de registro: ");
            NumeroDeRegistro = int.Parse(Console.ReadLine());

            Console.Write("Atualize o horário de trabalho: ");
            HorarioDeTrabalho = int.Parse(Console.ReadLine());
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id})\nNome: {Nome}\nCargo: {Cargo}\nNúmero de registro: {NumeroDeRegistro}\nHorário de Trabalho: {HorarioDeTrabalho}");
        }
    }
}
