int x;

Console.WriteLine("Insira um valor para ver a sequência dos números ímpares: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine(); // para pular uma linha no código

for (int i = 1; i < x; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}