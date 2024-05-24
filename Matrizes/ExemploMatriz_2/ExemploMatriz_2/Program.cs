int n;
int[,] a;

n = int.Parse(Console.ReadLine());

a = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        a[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine(); // para pular uma linha

Console.WriteLine("Diagonal Principal: ");

for (int i = 0; i < n; i++)
{
    Console.Write(a[i, i] + " ");
}

Console.WriteLine(); // para pular uma linha

int cont = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (a[i, j] < 0)
        {
            cont++;
        }
    }
}

Console.WriteLine("Quantidade de negativos: " + cont);

