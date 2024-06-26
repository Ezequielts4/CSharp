using SistemaGerenciamentoDeSupermercados;
using SistemaGerenciamentoDeSupermercados.Services;
using SistemaGerenciamentoDeSupermercados.Models;
using SistemaGerenciamentoDeSupermercados.Utils;
using Microsoft.VisualBasic;
using System.Globalization;

ClienteService clienteService = new ClienteService();
FuncionarioService funcionarioService = new FuncionarioService();
ProdutoService produtoService = new ProdutoService();
TransacaoService transacaoService = new TransacaoService();

bool continuar = true;

while (continuar)
{
    MenuPrincipal();
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            MenuClientes();
            Console.ReadKey();
            break;

        case 2:
            MenuFuncionario();
            Console.ReadKey();
            break;

        case 3:
            MenuProduto();
            Console.ReadKey();
            break;

        case 4:
            MenuTransacao();
            Console.ReadKey();
            break;

        case 5:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente...");
            break;
    }
}

// Métodos para os menu's

void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("---------- Sistema de Gerenciamento de Supermercado ----------");
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("Escolha o que deseja gerenciar abaixo");
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("1. Gerenciar Clientes");
    Console.WriteLine("2. Gerenciar Funcionários");
    Console.WriteLine("3. Gerenciar Produtos");
    Console.WriteLine("4. Gerenciar Transações de Vendas");
    Console.WriteLine("5. Sair");
    Console.WriteLine(); // para pular uma linha
    Console.Write("-> ");
}

void MenuClientes()
{
    Console.Clear();
    Console.WriteLine("---------- Gerenciador de Clientes ----------");
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("1. Adicionar cliente");
    Console.WriteLine("2. Remover cliente");
    Console.WriteLine("3. Atualizar clientes");
    Console.WriteLine("4. Listar clientes");
    Console.WriteLine("5. Voltar");
    Console.WriteLine(); // para pular uma linha
    Console.Write("-> ");

    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
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

void RemoverCliente(ClienteService clienteService)
{
    Console.Write("\nDigite o ID do cliente a ser removido: ");
    int id = int.Parse(Console.ReadLine());

    Cliente cliente = clienteService.BuscarClientePorId(id);

    if (cliente != null)
    {
        clienteService.RemoverCliente(cliente);
        Console.WriteLine("Cliente removido com sucesso!");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Cliente não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void AtualizarCliente(ClienteService clienteService)
{
    Console.Write("\nDigite o ID do cliente a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());

    Cliente cliente = clienteService.BuscarClientePorId(id);

    if (cliente != null)
    {
        cliente.Atualizar();
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Cliente não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void MenuFuncionario()
{
    Console.Clear();
    Console.WriteLine("---------- Gerenciador de Funcionários ----------");
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

void RemoverFuncionario(FuncionarioService funcionarioService)
{
    Console.Write("\nDigite o ID do funcionário a ser removido: ");
    int id = int.Parse(Console.ReadLine());

    Funcionario funcionario = funcionarioService.BuscarFuncionarioPorId(id);

    if (funcionario != null)
    {
        funcionarioService.RemoverFuncionario(funcionario);
        Console.WriteLine("Funcionário removido com sucesso!");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Funcionário não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void AtualizarFuncionario(FuncionarioService funcionarioService)
{
    Console.Write("\nDigite o ID do funcionário a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());

    Funcionario funcionario = funcionarioService.BuscarFuncionarioPorId(id);

    if (funcionario != null)
    {
        funcionario.Atualizar();
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Funcionário não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void MenuProduto()
{
    Console.Clear();
    Console.WriteLine("---------- Gerenciador de Produtos ----------");
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
            Produto produto = new Produto();

            produto.CriarProduto();
            produtoService.AdicionarProduto(produto);
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

void RemoverProduto(ProdutoService produtoService)
{
    Console.Write("\nDigite o ID do produto a ser removido: ");
    int id = int.Parse(Console.ReadLine());

    Produto produto = produtoService.BuscarProdutoPorId(id);

    if (produto != null)
    {
        produtoService.RemoverProduto(produto);
        Console.WriteLine("Produto removido com sucesso!");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Produto não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void AtualizarProduto(ProdutoService produtoService)
{
    Console.Write("\nDigite o ID do produto a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());

    Produto produto = produtoService.BuscarProdutoPorId(id);

    if (produto != null)
    {
        produto.AtualizarProduto();
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Produto não encontrado, tente novamente...");
        Console.ReadKey();
    }
}

void MenuTransacao()
{
    Console.Clear();
    Console.WriteLine("---------- Gerenciador de Transações de Vendas ----------");
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
            TransacaoDeVendas transacao = new TransacaoDeVendas();

            transacao.CriarTransacao();
            transacaoService.AdicionarTransacao(transacao);
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

void RemoverTransacao(TransacaoService transacaoService)
{
    Console.Write("\nDigite o ID da transação a ser removida: ");
    int id = int.Parse(Console.ReadLine());

    TransacaoDeVendas transacao = transacaoService.BuscarTransacaoPorId(id);

    if (transacao != null)
    {
        transacaoService.RemoverTransacao(transacao);
        Console.WriteLine("Transação removido com sucesso!");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Transação não encontrada, tente novamente...");
        Console.ReadKey();
    }
}

void AtualizarTransacao(TransacaoService transacaoService)
{
    Console.Write("\nDigite o ID da transação a ser atualizada: ");
    int id = int.Parse(Console.ReadLine());

    TransacaoDeVendas transacao = transacaoService.BuscarTransacaoPorId(id);

    if (transacao != null)
    {
        transacao.AtualizarTransacao();
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("Transação não encontrada, tente novamente...");
        Console.ReadKey();
    }
}
