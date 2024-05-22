using System.Globalization;

Console.Write("Insira o valor de N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

string[] nomes = new string[n];
int[] idades = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("\nInsira o nome e a idade da pessoa, respectivamente: ");
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
}

int maiorIdade = 0;

for (int i = 0; i < n; i++)
{
    if (idades[i] > maiorIdade)
    {
        maiorIdade = idades[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (idades[i] == maiorIdade)
    {
        Console.WriteLine("\nA pessoa mais velha é o(a): " + nomes[i]);
    }
}