double x, y;

Console.WriteLine("********COORDENADAS DE UM PONTO EM UM PLANO CARTESIANO********");

Console.Write("\nInsira o valor de X: ");
x = double.Parse(Console.ReadLine());

Console.Write("\nInsira o valor de Y: ");
y = double.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("\nQ1");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("\nQ2");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("\nQ3");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("\nQ4");
}

else if (x == 0 && y > 0)
{
    Console.WriteLine("\nEixo X");
}

else if (x == 0 && y < 0)
{
    Console.WriteLine("\nEixo X");
}

else if (y == 0 && x > 0)
{
    Console.WriteLine("\nEixo Y");
}

else if (y == 0 && x < 0)
{
    Console.WriteLine("\nEixo Y");
}

else
{
    Console.WriteLine("\nOrigem");

}

Console.ReadKey();
