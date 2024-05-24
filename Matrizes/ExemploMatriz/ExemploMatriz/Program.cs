int l, c;
int[,] a;

string[] s = Console.ReadLine().Split(' ');

l = int.Parse(s[0]);
c = int.Parse(s[1]);

a = new int[l, c];

// para receber os valores nos seus devidos lugares
for (int i = 0; i < l; i++)
{
    string[] vet = Console.ReadLine().Split(' ');

    for (int j = 0; j < c; j++)
    {
        a[i,j] = int.Parse(vet[j]);
    }
}

Console.WriteLine(); // para pular uma linha

for (int i = 0; i < l; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write(a[i,j] + " ");
    }
    Console.WriteLine();
}
