int x, soma = 0;

do
{
    Console.WriteLine("Insira um número: ");
    x = int.Parse(Console.ReadLine());

    if (x > 0)
    {
        soma += x;
    }
}

while (x > 0);

Console.WriteLine("A soma dos positivos é: " + soma);