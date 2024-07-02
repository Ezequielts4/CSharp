using SistemaGerenciamentoDeSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int diaValidade { get; set; }
        public int mesValidade { get; set; }
        public int anoValidade { get; set; }

        public Produto(string nome, string categoria, double preco, int quantidadeEstoque, int diaValidade, int mesValidade, int anoValidade) 
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.Preco = preco;
            this.QuantidadeEmEstoque = quantidadeEstoque;
            this.diaValidade = diaValidade;
            this.mesValidade = mesValidade;
            this.anoValidade = anoValidade;
        }
        public Produto() { }

        public void CriarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Preencha as informações abaixo para cadastrar um produto   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            Console.Write("Insira o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Insira a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            string[] data = new string[3];
            Console.Write("Insira a data de validade (dd/mm/yyyy): ");
            data = Console.ReadLine().Split("/");

            diaValidade = int.Parse(data[0]);
            mesValidade = int.Parse(data[1]);
            anoValidade = int.Parse(data[2]);

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Cadastrando um novo produto", 1000, 3, "VERDE");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nProduto adicionado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void AtualizarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Atualize os dados do produto abaixo   ");
            Console.ResetColor();

            Console.WriteLine(); // para pular uma linha
            Console.Write("Atualize o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Atualize o preço do produto: ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Atualize a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            string[] data = new string[3];
            Console.Write("Atualize a data de validade (dd/mm/yyyy): ");
            data = Console.ReadLine().Split("/");

            diaValidade = int.Parse(data[0]);
            mesValidade = int.Parse(data[1]);
            anoValidade = int.Parse(data[2]);

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Atualizando dados", 1000, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nProduto atualizado com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nCategoria: {Categoria}\nPreço: {Preco:C}\nQuantidade em estoque: {QuantidadeEmEstoque}\nData de validade: {diaValidade}/{mesValidade}/{anoValidade}");
        }
    }
}