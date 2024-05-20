int maior = int.Parse(Console.ReadLine());
int posicao = 0;

for (int i = 1; i <= 10; i++)
{
    int x = int.Parse(Console.ReadLine());

    if (x > maior)
    {
        maior = x;
        posicao = i;
    }
}

Console.WriteLine("O maior número é o: " + maior);
Console.WriteLine("Ele está na " + posicao + "º posição");