double valor;

Console.WriteLine("********DESCUBRA EM QUAL INTERVALO O VALOR SE ENCONTRA********");

Console.Write("\nInsira um valor: ");
valor = double.Parse(Console.ReadLine());

if (valor > 0 && valor <= 25)
{
    Console.WriteLine("Intervalo [0,25]");
}

else if (valor > 25 && valor <= 50)
{
    Console.WriteLine("Intervalo [25,50]");
}

else if (valor > 50 && valor <= 75)
{
    Console.WriteLine("Intervalo [75,100]");
}

else if (valor > 75 && valor <= 100)
{
    Console.WriteLine("Intervalo [75,100]");
}

else
{
    Console.WriteLine("Fora de Intervalo");
}

Console.ReadKey();