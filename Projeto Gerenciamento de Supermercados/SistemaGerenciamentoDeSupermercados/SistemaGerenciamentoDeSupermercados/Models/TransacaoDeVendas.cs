using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string ListaDeProdutosComprados { get; set; }
        public float ValorTotal { get; set; }

        public void CriarTransacao()
        {
            Console.WriteLine(); // para pular uma linha
            Console.Write("Insira o ID do cliente: ");
            IdDoCliente = int.Parse(Console.ReadLine());

            Console.Write("Insira o ID do funcionário: ");
            IdDoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Insira o(s) produto(s) comprado(s): ");
            ListaDeProdutosComprados = Console.ReadLine();

            Console.Write("Insira o valor total da(s) venda(s): ");
            ValorTotal = float.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Transação adicionada com sucesso!");
        }

        public virtual void AtualizarTransacao()
        {
            Console.WriteLine(); // para pular uma linha
            Console.Write("Atualize o ID do cliente: ");
            IdDoCliente = int.Parse(Console.ReadLine());

            Console.Write("Atualize o ID do funcionário: ");
            IdDoFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Atualize o(s) produto(s) comprado(s): ");
            ListaDeProdutosComprados = Console.ReadLine();

            Console.Write("Atualize o valor total da(s) venda(s): ");
            ValorTotal = float.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("Transação atualizada com sucesso!");
        }
        
        public virtual void MostrarDetalhes()
        {
            var DataHora = DateTime.Now;

            string dataFormatada = DataHora.ToString("dd/MM/yyyy");
            string horaFormatada = DataHora.ToString("HH:mm:ss");

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nID do Cliente: {IdDoCliente}\nID do Funcionário: {IdDoFuncionario}\nData da transação: {dataFormatada}\nHora da transação: {horaFormatada}\nProduto(s) comprado(s): {ListaDeProdutosComprados}\nValor total da(s) venda(s): {ValorTotal:C}");
        }
    }
}
