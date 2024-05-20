int A, B;

Console.Write("Insira o placar do Time A: ");
A = int.Parse(Console.ReadLine());

Console.Write("Insira o placar do Time B: ");
B = int.Parse(Console.ReadLine());


if (A == B)
{
    Console.WriteLine("O resultado do jogo foi empate!");
}
else
{
    if (A > B)
    {
        Console.WriteLine("A vitória foi do time A");
    }
    else
    {
        Console.WriteLine("A vitória foi do time B");
    }
}
Console.ReadLine();