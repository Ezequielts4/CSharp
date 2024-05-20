int x = 1;

while (!(x > 5 && x < 2000))
{
    Console.WriteLine("Insira um valor: ");
    x = int.Parse(Console.ReadLine());
}

Console.WriteLine(); // para pular uma linha no código

for (int i = 1; i <= x; i++)
{
    if (i % 2 == 0)
    {
        int quadrado = i * i;
        Console.WriteLine(i + "^2 = " + quadrado);
    }
}