using SistemaGerenciamentoDeSupermercados;
using SistemaGerenciamentoDeSupermercados.Services;
using SistemaGerenciamentoDeSupermercados.Models;
using SistemaGerenciamentoDeSupermercados.Utils;
using Microsoft.VisualBasic;
using System.Globalization;

bool continuar = true;

while (continuar)
{
    Menu.MenuPrincipal();
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Menu.MenuCliente();
            break;

        case 2:
            Menu.MenuFuncionario();
            break;

        case 3:
            Menu.MenuProduto();
            break;

        case 4:
            Menu.MenuTransacao();
            break;

        case 5:
            Console.WriteLine(); // para pular uma linha
            DisplayHelper.BarraCarregamento("Desligando sistema", 700, 3, "VERMELHO");
            Console.WriteLine(); // para pular uma linha
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Por favor, insira um valor correspondente a tabela... ");
            Console.Write("-> ");
            break;
    }
}