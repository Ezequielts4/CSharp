int repeticao, valor, dentro = 0, fora = 0;

Console.WriteLine("Digite o número de entradas");
repeticao = int.Parse(Console.ReadLine());

for (int i = repeticao; i > 0; i--)
{
    valor = int.Parse(Console.ReadLine());

    if (valor >= 10 && valor <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine("Estão dentro: " + dentro);
Console.WriteLine("Estão fora: " + fora);