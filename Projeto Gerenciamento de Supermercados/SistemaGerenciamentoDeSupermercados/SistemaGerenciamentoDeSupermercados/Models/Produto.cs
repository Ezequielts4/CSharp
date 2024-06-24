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
        public int Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int DataDeValidade { get; set; }

        public virtual void CriarProduto()
        {
            Console.Write("Insira o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Insira a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            Preco = int.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.Write("Insira a data de validade: ");
            DataDeValidade = int.Parse(Console.ReadLine());
        }

        public virtual void AtualizarProduto()
        {
            Console.Write("Atualize o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Atualize o preço do produto: ");
            Preco = int.Parse(Console.ReadLine());

            Console.Write("Atualize a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.Write("Atualize a data de validade: ");
            DataDeValidade = int.Parse(Console.ReadLine());
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id})\nNome: {Nome}\nCategoria: {Categoria}\nPreço: {Preco:C}\nQuantidade em estoque: {QuantidadeEmEstoque}\nData de validade: {DataDeValidade}");
        }
    }
}

