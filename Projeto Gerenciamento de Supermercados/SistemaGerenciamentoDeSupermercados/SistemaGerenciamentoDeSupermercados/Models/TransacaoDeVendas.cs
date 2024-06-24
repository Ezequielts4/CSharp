using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Models
{
    public class TransacaoDeVendas
    {
        public int Id { get; set; }
        public int IdDoCliente { get; set; }
        public int IdDoFuncionario { get; set; }
        public int DataTransacao { get; set; }
        public int HoraTransacao { get; set; }
        public string ListaDeProdutosComprados { get; set; }
        public float ValorTotal { get; set; }

        public virtual void CriarTransacao()
        {
            Console.Write("Insira o ID do cliente: ");
            IdDoCliente = int.Parse(Console.ReadLine());

            Console.Write("Insira o ID do funcionário: ");
            IdDoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Insira a data de transação: ");
            DataTransacao = int.Parse(Console.ReadLine());

            Console.Write("Insira a hora de transação: ");
            HoraTransacao = int.Parse(Console.ReadLine());

            Console.Write("Insira o(s) produto(s) comprado(s): ");
            ListaDeProdutosComprados = Console.ReadLine();

            Console.Write("Insira o valor total da(s) venda(s): ");
            ValorTotal = float.Parse(Console.ReadLine());
        }

        public virtual void AtualizarTransacao()
        {
            Console.Write("Atualize o ID do cliente: ");
            IdDoCliente = int.Parse(Console.ReadLine());

            Console.Write("Atualize o ID do funcionário: ");
            IdDoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Atualize a data de transação: ");
            DataTransacao = int.Parse(Console.ReadLine());

            Console.Write("Atualize a hora de transação: ");
            HoraTransacao = int.Parse(Console.ReadLine());

            Console.Write("Atualize o(s) produto(s) comprado(s): ");
            ListaDeProdutosComprados = Console.ReadLine();

            Console.Write("Atualize o valor total da(s) venda(s): ");
            ValorTotal = float.Parse(Console.ReadLine());
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id})\nID do Cliente: {IdDoCliente}\nID do Funcionário: {IdDoFuncionario}\nData da transação: {DataTransacao}\nHora da transação: {HoraTransacao}\nProduto(s) comprado(s): {ListaDeProdutosComprados}\nValor total da(s) venda(s): {ValorTotal:C}");

        }
    }
}
