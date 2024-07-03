using SistemaGerenciamentoDeSupermercados.Services;
using SistemaGerenciamentoDeSupermercados.Utils;

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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Preencha as informações abaixo para realizar uma transação   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            Console.Write("Insira o ID do cliente: ");
            IdDoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Procurando cliente", 700, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha

            Console.Write("\nInsira o ID do funcionário: ");
            IdDoFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Procurando funcionário", 700, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha

            Console.Write("\nInsira o(s) produto(s) comprado(s): ");
            ListaDeProdutosComprados = Console.ReadLine();

            Console.Write("\nInsira o valor total da(s) venda(s): ");
            ValorTotal = float.Parse(Console.ReadLine());

            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Cadastrando uma nova transação", 1000, 3, "VERDE");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nTransação realizada com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void AtualizarTransacao()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Atualize os dados da transação abaixo   ");
            Console.ResetColor();

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
            DisplayHelper.BarraCarregamento("Atualizando dados", 1000, 3, "CIANO");
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("\nTransação atualizada com sucesso!");
            Console.Write("Pressione qualquer tecla para continuar...");
        }

        public void MostrarDetalhes()
        {
            var DataHora = DateTime.Now;

            string dataFormatada = DataHora.ToString("dd/MM/yyyy");
            string horaFormatada = DataHora.ToString("HH:mm:ss");

            Console.WriteLine(); // para pular uma linha
            Console.WriteLine($"ID: {Id}\nID do Cliente: {IdDoCliente}\nID do Funcionário: {IdDoFuncionario}\nData da transação: {dataFormatada}\nHora da transação: {horaFormatada}\nProduto(s) comprado(s): {ListaDeProdutosComprados}\nValor total da(s) venda(s): {ValorTotal:C}");
        }
    }
}