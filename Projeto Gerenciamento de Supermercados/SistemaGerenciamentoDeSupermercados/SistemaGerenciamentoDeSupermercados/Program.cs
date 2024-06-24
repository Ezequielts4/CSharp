using SistemaGerenciamentoDeSupermercados.Models;
using SistemaGerenciamentoDeSupermercados.Services;
using SistemaGerenciamentoDeSupermercados.Utils;
using SistemaGerenciamentoDeSupermercados;

ClienteService clienteService = new ClienteService();
FuncionarioService funcionarioService = new FuncionarioService();
ProdutoService produtoService = new ProdutoService();
TransacaoService transacaoService = new TransacaoService();

bool continuar = true;

while (continuar)
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
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            
            break;

        case 2:

            break;

        case 3:

            break;

        case 4:

            break;

        case 5:
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente...");
            break;
    }
}

void menuClientes()
{
    Console.Clear();
    Console.WriteLine("1. Adicionar cliente");
    Console.WriteLine("2. Remover cliente");
    Console.WriteLine("3. Atualizar clientes");
    Console.WriteLine("4. Listar clientes");
    Console.WriteLine("5. Voltar");
    int escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Cliente cliente = Cliente.CriarCliente();
            clienteService.AdicionarCliente(cliente);
            break;

        case 2:
            

            break;

        case 3:
            

            break;

        case 4:
            

            break;

        case 5:
            

            break;

        default:
            break;
    } 
}