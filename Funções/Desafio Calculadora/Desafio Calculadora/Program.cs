using System.Globalization;
using static System.Net.Mime.MediaTypeNames;        

double a = 0, b = 0;
bool menu = true;

while (menu == true)
{

    Console.WriteLine("********CALCULADORA BÁSICA********");

    Console.WriteLine(); // para pular uma linha

    Console.WriteLine("ESCOLHA UMA DAS OPERAÇÕES ABAIXO: \n1 - ADIÇÃO\n2 - SUBTRAÇÃO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO\n\nOU DIGITE 'SAIR' PARA FECHAR O PROGRAMA...");
    string escolha = Console.ReadLine().ToLower();

    Console.WriteLine(); // para pular uma linha

    if (escolha == "1")
    {
        Console.Write("Digite o primeiro valor a ser calculado: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor a ser calculado: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine(); // para pular uma linha

        double resultado = Adicao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "2")
    {

        Console.Write("Digite o primeiro valor a ser calculado: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor a ser calculado: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine(); // para pular uma linha

        double resultado = Subtracao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "3")
    {
        Console.Write("Digite o primeiro valor a ser calculado: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor a ser calculado: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine(); // para pular uma linha

        double resultado = Multiplicacao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "4")
    {
        Console.Write("Digite o primeiro valor a ser calculado: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor a ser calculado: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine(); // para pular uma linha

        double resultado = Divisao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "sair")
    {
        Exit();

        menu = false;

        /* não achei a maneira de fechar o terminal automaticamente, mas ela estaria aqui :( */
    }

    else
    {
        while (escolha != "1" && escolha != "2" && escolha != "3" && escolha != "4")
        {
            Console.WriteLine("Por favor, insira um número correspondente à tabela...");
            escolha = Console.ReadLine().ToLower();

            if (escolha == "1")
            {
                Console.Write("\nDigite o primeiro valor a ser calculado: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor a ser calculado: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(); // para pular uma linha

                double resultado = Adicao(a, b);
                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (escolha == "2")
            {

                Console.Write("\nDigite o primeiro valor a ser calculado: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor a ser calculado: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(); // para pular uma linha

                double resultado = Subtracao(a, b);
                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (escolha == "3")
            {
                Console.Write("\nDigite o primeiro valor a ser calculado: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor a ser calculado: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(); // para pular uma linha

                double resultado = Multiplicacao(a, b);
                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (escolha == "4")
            {
                Console.Write("\nDigite o primeiro valor a ser calculado: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor a ser calculado: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(); // para pular uma linha

                double resultado = Divisao(a, b);
                Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
    Console.ReadKey();

    Console.Clear();
}


// MÉTODOS

// adição
static double Adicao(double a, double b)
{
    double x;

    x = a + b;

    return x;
    Console.Clear();
}

// subtração
static double Subtracao(double a, double b)
{
    double x;

    x = a - b;

    return x;
}

// multiplicação
static double Multiplicacao(double a, double b)
{
    double x;

    x = a * b;

    return x;
}

// divisão
static double Divisao(double a, double b)
{
    double x;

    if (b == 0)
    {
        Console.WriteLine("Não é possível dividir o número escolhido por zero...\nPor favor, insira um número diferente");
        b = double.Parse(Console.ReadLine());

        while (b == 0)
        {
            Console.WriteLine("Não é possível dividir o número escolhido por zero...\nPor favor, insira um número diferente");
            b = double.Parse(Console.ReadLine());
        }
    }

    x = a / b;

    return x;
}

static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write(texto);
    for (int i = 0; i < quantidade; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.WriteLine("\n\nPrograma encerrado com sucesso!\nPressione Enter para sair...");

    Console.ResetColor();

    Console.ReadKey();
}

static void Exit()
{
    BarraCarregamento("Estamos encerrando o programa", 1500, 3);

    bool menu = false;

    /* não achei a maneira de fechar o terminal automaticamente, mas ela estaria aqui :( */
}