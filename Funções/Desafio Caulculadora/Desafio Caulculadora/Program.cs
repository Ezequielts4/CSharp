using System.Globalization;

bool menu = true;

    Console.WriteLine("********CALCULADORA BÁSICA********");

    Console.WriteLine(); // para pular uma linha

    Console.WriteLine("ESCOLHA UMA DAS OPERAÇÕES ABAIXO: \n1 - ADIÇÃO\n2 - SUBTRAÇÃO\n3 - MULTIPLICAÇÃO\n4 - DIVISÃO");
    string escolha = Console.ReadLine();

    Console.WriteLine(); // para pular uma linha

    Console.Write("Digite o primeiro valor a ser calculado: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor a ser calculado: ");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine(); // para pular uma linha

    if (escolha == "1")
    {
        double resultado = Adicao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "2")
    {
        double resultado = Subtracao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else if (escolha == "3")
    {
        double resultado = Multiplicacao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }

    else 
    {
        double resultado = Divisao(a, b);
        Console.WriteLine("O resultado da operação é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }
    


Console.WriteLine("Calculadora encerrada");

Console.ReadKey();

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


/* carregamento */

/*
BarraCarregamento("Olá!", 1000, 5);
static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write(texto);
    for (int i = 0; i < quantidade; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}
*/