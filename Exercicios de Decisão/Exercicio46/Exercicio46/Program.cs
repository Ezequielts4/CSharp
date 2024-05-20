int h1, h2;

Console.WriteLine("********DESCUBRA O TEMPO DE JOGO********");

Console.Write("\nInsira a hora que iniciou o jogo: ");
h1 = int.Parse(Console.ReadLine());

Console.Write("\nInsira a hora que terminou o jogo: ");
h2 = int.Parse(Console.ReadLine());

if (h1 > h2)
{
    Console.WriteLine("\nO JOGO DUROU " + (24 - (h1 - h2)) + " HORA(S)");
}
else if (h2 > h1)
{
    Console.WriteLine("\nO JOGO DUROU " + (h2 - h1) + " HORA(S)");
}

else
{
    Console.WriteLine("\nO JOGO DUROU 24 HORA(S)");
}