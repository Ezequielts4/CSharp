int x, y, soma = 0;

Console.WriteLine("Digite o valor de X: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de Y: ");
y = int.Parse(Console.ReadLine());

if (y < x)
{
    int z = x;
    x = y;
    y = z;
}

for (int i = x + 1; i < y; i++)
{
    if (i % 2 != 0)
    {
        soma += i;
    }
}

Console.WriteLine("A soma dos números impares é igual a: " + soma);