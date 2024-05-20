using System.Globalization;

int codigo, quantidade;

Console.WriteLine("********TABELA DE LANCHES********");

Console.Write("\nInsira o código do lanche aqui: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("\nInsira a quantidade pedida aqui: ");
quantidade = int.Parse(Console.ReadLine());

if (codigo == 1)
{
    Console.WriteLine("\nTotal: R$ " + (4.00 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
}

else if (codigo == 2)
{
    Console.WriteLine("\nTotal: R$ " + (4.50 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
}

else if (codigo == 3)
{
    Console.WriteLine("\nTotal: R$ " + (5.00 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
}

else if (codigo == 4)
{
    Console.WriteLine("\nTotal: R$ " + (2.00 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
}

else
{
    Console.WriteLine("\nTotal: R$ " + (1.50 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
}

Console.ReadKey();
