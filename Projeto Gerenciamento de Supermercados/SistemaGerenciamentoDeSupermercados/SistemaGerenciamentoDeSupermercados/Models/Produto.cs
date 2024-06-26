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
        public float Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int DataDeValidade { get; set; }

        public void CriarProduto()
        {
            Console.WriteLine(); // para pular uma linha
            Console.Write("Insira o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Insira a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Insira o preço do produto: ");
            Preco = float.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.Write("Insira a data de validade: ");
            DataDeValidade = int.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public virtual void AtualizarProduto()
        {
            Console.WriteLine(); // para pular uma linha
            Console.Write("Atualize o nome do produto: ");
            Nome = Console.ReadLine();

            Console.Write("Atualize a categoria do produto: ");
            Categoria = Console.ReadLine();

            Console.Write("Atualize o preço do produto: ");
            Preco = float.Parse(Console.ReadLine());

            Console.Write("Atualize a quantidade de produto em estoque: ");
            QuantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.Write("Atualize a data de validade: ");
            DataDeValidade = int.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Produto atualizado com sucesso!");
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nNome: {Nome}\nCategoria: {Categoria}\nPreço: {Preco:C}\nQuantidade em estoque: {QuantidadeEmEstoque}\nData de validade: {DataDeValidade}");
        }
    }
}

