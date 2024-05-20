using System.Globalization;

double salario, novoSalario, reajuste, percentual;

Console.WriteLine("********VERIFIQUE O AUMENTO NO SEU SALÁRIO********");

Console.Write("\nInsira o seu salário (com duas casas decimais): ");

salario = double.Parse(Console.ReadLine());


if (salario <= 400.00)
{
    reajuste = salario * 0.15;
    novoSalario = salario + reajuste;
    percentual = 15;

    Console.WriteLine("\nNovo Salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em Percentual: " + percentual + "%");
}

else if (salario > 400 && salario <= 800)
{
    reajuste = salario * 0.12;
    novoSalario = salario + reajuste;
    percentual = 12;

    Console.WriteLine("\nNovo Salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em Percentual: " + percentual + "%");
}

else if (salario > 800.01 && salario <= 1200)
{
    reajuste = salario * 0.10;
    novoSalario = salario + reajuste;
    percentual = 10;

    Console.WriteLine("\nNovo Salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em Percentual: " + percentual + "%");
}

else if (salario > 1200.01 && salario <= 2000)
{
    reajuste = salario * 0.07;
    novoSalario = salario + reajuste;
    percentual = 0.7;

    Console.WriteLine("\nNovo Salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em Percentual: " + percentual + "%");
}

else
{
    reajuste = salario * 0.04;
    novoSalario = salario + reajuste;
    percentual = 0.4;

    Console.WriteLine("\nNovo Salário: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste Ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em Percentual: " + percentual + "%");
}
