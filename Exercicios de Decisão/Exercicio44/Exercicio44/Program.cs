int v1, v2;

Console.WriteLine("********DESCUBRA SE OS VALORES SÃO MÚLTIPLOS********");

Console.Write("\nInsira o primeiro valor: ");
v1 = int.Parse(Console.ReadLine());

Console.Write("\nInsira o segundo valor: ");
v2 = int.Parse(Console.ReadLine());

if (v1 % v2 == 0 || v2 % v1 == 0)
{
    Console.WriteLine("\nSão Múltiplos");
}

else
{
    Console.WriteLine("\nNão são Múltiplos");
}

Console.ReadKey();