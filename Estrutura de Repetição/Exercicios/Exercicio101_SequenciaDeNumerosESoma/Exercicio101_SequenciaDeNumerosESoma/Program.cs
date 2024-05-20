/*int m = 1, n = 1, soma = 0;

while (m > 0 && n > 0)
{
    Console.WriteLine("\nInsira o conjunto de valores: ");
    string[] valor = Console.ReadLine().Split(' ');

    m = int.Parse(valor[0]);
    n = int.Parse(valor[1]);

    if (m == 0 || n == 0)
    {
        break;
    }

    if (m > n)
    {
        int x = n;
        n = m;
        m = x;
    }

    for (int sequencia = m; sequencia <= n; sequencia++)
    {
        Console.Write($" {sequencia}");

        soma += sequencia;
    }

    Console.WriteLine(" Soma = " + soma);
    soma = 0;
}

Console.WriteLine("\nInsira apenas números inteiros positivos...");*/

/* correção - correção - correção - correção - correção*/

string[] valores = Console.ReadLine().Split(' ');
int m = int.Parse(valores[0]);
int n = int.Parse(valores[1]);

while(m > 0 && n > 0)
{
    int menor = m;
    int maior = n;

    if(m > n)
    {
        menor = n;
        maior = m;
    }

    int soma = 0;
    for (int i = menor; i <= maior; i++)
    {
        soma += i;
        Console.Write(i + " ");
    }

    Console.WriteLine("Sum= " + soma);

    valores = Console.ReadLine().Split(' ');
    m = int.Parse(valores[0]);
    n = int.Parse(valores[1]);

}

