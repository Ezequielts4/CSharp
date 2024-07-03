using SistemaGerenciamentoDeSupermercados;
using SistemaGerenciamentoDeSupermercados.Models;
using SistemaGerenciamentoDeSupermercados.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoDeSupermercados.Utils
{
    public static class DisplayHelper
    {
        public static void MostrarDetalhes(ClienteService clienteService)
        {
            var itens = clienteService.ListarClientes();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(FuncionarioService detalhesFuncionario)
        {
            var itens = detalhesFuncionario.ListarFuncionario();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(ProdutoService detalhesProduto)
        {
            var itens = detalhesProduto.ListarProduto();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void MostrarDetalhes(TransacaoService detalhesTransacao)
        {
            var itens = detalhesTransacao.ListarTransacao();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }

        public static void BarraCarregamento(string texto, int tempo, int quantidade, string cor)
        {
            if (cor == "VERDE")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else if (cor == "VERMELHO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.Write(texto);
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
        }
    }

    // MENU - MENU - MENU - MENU - MENU - MENU - MENU - MENU - MENU - MENU - MENU 

    public static class Menu
    {
        static ClienteService clienteService = new ClienteService();
        static FuncionarioService funcionarioService = new FuncionarioService();
        static ProdutoService produtoService = new ProdutoService();
        static TransacaoService transacaoService = new TransacaoService();

        static Produto produto = new Produto();
        static TransacaoDeVendas transacao = new TransacaoDeVendas();

        public static void MenuPrincipal()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                ");
            Console.WriteLine("----------- Sistema de Gerenciamento de Supermercado -----------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("   Escolha o que deseja gerenciar abaixo   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("1. Gerenciar Clientes");
            Console.WriteLine("2. Gerenciar Funcionários");
            Console.WriteLine("3. Gerenciar Produtos");
            Console.WriteLine("4. Gerenciar Transações de Vendas");
            Console.WriteLine("5. Sair");
            Console.WriteLine(); // para pular uma linha
            Console.Write("-> ");
        }

        public static void MenuCliente()
        {
            #region Cliente Predefinidos
            Cliente cliente1 = new Cliente("Marcos", 11, 12, 2005, "Rua senai, 308", "11223344556");
            Cliente cliente2 = new Cliente("André", 13, 11, 2020, "Rua tal, 474", "11223344556");

            clienteService.AdicionarCliente(cliente1);
            clienteService.AdicionarCliente(cliente2);
            #endregion

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---------- Gerenciador de Clientes ----------");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("1. Adicionar cliente");
            Console.WriteLine("2. Remover cliente");
            Console.WriteLine("3. Atualizar clientes");
            Console.WriteLine("4. Listar clientes");
            Console.WriteLine("5. Voltar");
            Console.WriteLine(); // para pular uma linha
            Console.Write("-> ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cliente cliente = Cliente.CriarCliente();
                    clienteService.AdicionarCliente(cliente);
                    break;

                case 2:
                    RemoverCliente(clienteService);
                    Console.ReadKey();
                    break;

                case 3:
                    AtualizarCliente(clienteService);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Clientes cadastrados   ");
                    Console.ResetColor();
                    DisplayHelper.MostrarDetalhes(clienteService);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente...");
                    Console.ReadKey();
                    break;
            }
        }

        public static void RemoverCliente(ClienteService clienteService)
        {
            var lista = clienteService.ListarClientes();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Clientes cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do cliente a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clienteService.BuscarClientePorId(id);

            if (cliente != null)
            {
                clienteService.RemoverCliente(cliente);
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Removendo cliente", 1000, 3, "VERMELHO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nCliente removido com sucesso!");
                Console.Write("Pressione qualquer tecla para continuar...");
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando cliente", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nCliente não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void AtualizarCliente(ClienteService clienteService)
        {
            var lista = clienteService.ListarClientes();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Clientes cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do cliente a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clienteService.BuscarClientePorId(id);

            if (cliente != null)
            {
                cliente.Atualizar();
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando cliente", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nCliente não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void MenuFuncionario()
        {
            #region Funcionarios Predefinidos
            Funcionario funcionario1 = new Funcionario("Maria", "Vendedora", 21, "8");
            Funcionario funcionario2 = new Funcionario("Gabriel", "Gerente", 15, "8");

            funcionarioService.AdicionarFuncionario(funcionario1);
            funcionarioService.AdicionarFuncionario(funcionario2);
            #endregion

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---------- Gerenciador de Funcionários ----------");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("1. Adicionar funcionário");
            Console.WriteLine("2. Remover funcionário");
            Console.WriteLine("3. Atualizar funcionário");
            Console.WriteLine("4. Listar funcionários");
            Console.WriteLine("5. Voltar");
            Console.WriteLine(); // para pular uma linha
            Console.Write("-> ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Funcionario funcionario = Funcionario.CriarFuncionario();
                    funcionarioService.AdicionarFuncionario(funcionario);
                    break;

                case 2:
                    RemoverFuncionario(funcionarioService);
                    Console.ReadKey();
                    break;

                case 3:
                    AtualizarFuncionario(funcionarioService);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Funcionários cadastrados   ");
                    Console.ResetColor();
                    DisplayHelper.MostrarDetalhes(funcionarioService);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente...");
                    Console.ReadKey();
                    break;
            }
        }

        public static void RemoverFuncionario(FuncionarioService funcionarioService)
        {
            var lista = funcionarioService.ListarFuncionario();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Funcionários cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do funcionário a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarioService.BuscarFuncionarioPorId(id);

            if (funcionario != null)
            {
                funcionarioService.RemoverFuncionario(funcionario);

                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Removendo funcionário", 1000, 3, "VERMELHO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nFuncionário removido com sucesso!");
                Console.Write("Pressione qualquer tecla para continuar...");
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando funcionário", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nFuncionário não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void AtualizarFuncionario(FuncionarioService funcionarioService)
        {
            var lista = funcionarioService.ListarFuncionario();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Funcionários cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do funcionário a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarioService.BuscarFuncionarioPorId(id);

            if (funcionario != null)
            {
                funcionario.Atualizar();
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando funcionário", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nFuncionário não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void MenuProduto()
        {
            #region Produtos Predefinidos
            Produto prod1 = new Produto("Pão", "Padaria", 10.0, 10, 07, 12, 2024);
            Produto prod2 = new Produto("Croissaint", "Padaria", 15.0, 10, 07, 12, 2024);

            produtoService.AdicionarProduto(prod1);
            produtoService.AdicionarProduto(prod2);
            #endregion

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---------- Gerenciador de Produtos ----------");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Remover produto");
            Console.WriteLine("3. Atualizar produto");
            Console.WriteLine("4. Listar produtos");
            Console.WriteLine("5. Voltar");
            Console.WriteLine(); // para pular uma linha
            Console.Write("-> ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    //Produto.CriarProduto();
                    produtoService.AdicionarProduto(Produto.CriarProduto());
                    break;

                case 2:
                    RemoverProduto(produtoService);
                    Console.ReadKey();
                    break;

                case 3:
                    AtualizarProduto(produtoService);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Produtos cadastrados   ");
                    Console.ResetColor();
                    DisplayHelper.MostrarDetalhes(produtoService);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente...");
                    Console.ReadKey();
                    break;
            }
        }

        public static void RemoverProduto(ProdutoService produtoService)
        {
            var lista = produtoService.ListarProduto();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Produtos cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do produto a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtoService.BuscarProdutoPorId(id);

            if (produto != null)
            {
                produtoService.RemoverProduto(produto);

                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Removendo produto", 1000, 3, "VERMELHO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nProduto removido com sucesso!");
                Console.Write("Pressione qualquer tecla para continuar...");
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando produto", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nProduto não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void AtualizarProduto(ProdutoService produtoService)
        {
            var lista = produtoService.ListarProduto();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Produtos cadastrados   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id} || Nome: {item.Nome}");
            }

            Console.Write("\nDigite o ID do produto a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtoService.BuscarProdutoPorId(id);

            if (produto != null)
            {
                produto.AtualizarProduto();
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando produto", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nProduto não encontrado, verifique se os dados estão corretos...");
            }
        }

        public static void MenuTransacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---------- Gerenciador de Transações de Vendas ----------");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha
            Console.WriteLine("1. Adicionar transação");
            Console.WriteLine("2. Remover transação");
            Console.WriteLine("3. Atualizar transação");
            Console.WriteLine("4. Listar transações");
            Console.WriteLine("5. Voltar");
            Console.WriteLine(); // para pular uma linha
            Console.Write("-> ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    transacaoService.AdicionarTransacao(TransacaoDeVendas.CriarTransacao());
                    break;

                case 2:
                    RemoverTransacao(transacaoService);
                    Console.ReadKey();
                    break;

                case 3:
                    AtualizarTransacao(transacaoService);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("\n   Transações cadastradas   ");
                    Console.ResetColor();
                    DisplayHelper.MostrarDetalhes(transacaoService);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente...");
                    Console.ReadKey();
                    break;
            }
        }

        public static void RemoverTransacao(TransacaoService transacaoService)
        {
            var lista = transacaoService.ListarTransacao();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Transações cadastradas   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id}\nFuncionário: {item.IdDoFuncionario}\nCliente: {item.IdDoCliente}\nProduto(s): {item.ListaDeProdutosComprados}");
            }

            Console.Write("\nDigite o ID da transação a ser removida: ");
            int id = int.Parse(Console.ReadLine());

            TransacaoDeVendas transacao = transacaoService.BuscarTransacaoPorId(id);

            if (transacao != null)
            {
                transacaoService.RemoverTransacao(transacao);

                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Removendo transação", 1000, 3, "VERMELHO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nTransação removida com sucesso!");
                Console.Write("Pressione qualquer tecla para continuar...");
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando transação", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nTransação não encontrada, verifique se os dados estão corretos...");
            }
        }

        public static void AtualizarTransacao(TransacaoService transacaoService)
        {
            var lista = transacaoService.ListarTransacao();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n   Transações cadastradas   ");
            Console.ResetColor();
            Console.WriteLine(); // para pular uma linha

            foreach (var item in lista)
            {
                Console.WriteLine($"ID: {item.Id}\nFuncionário: {item.IdDoFuncionario}\nCliente: {item.IdDoCliente}\nProduto(s): {item.ListaDeProdutosComprados}");
            }

            Console.Write("\nDigite o ID da transação a ser atualizada: ");
            int id = int.Parse(Console.ReadLine());

            TransacaoDeVendas transacao = transacaoService.BuscarTransacaoPorId(id);

            if (transacao != null)
            {
                transacao.AtualizarTransacao();
            }

            else
            {
                Console.WriteLine(); // para pular uma linha
                DisplayHelper.BarraCarregamento("Procurando transação", 1000, 3, "CIANO");
                Console.WriteLine(); // para pular uma linha
                Console.WriteLine("\nTransação não encontrada, verifique se os dados estão corretos...");
            }
        }
    }
}