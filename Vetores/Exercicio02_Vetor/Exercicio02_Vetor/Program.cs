using System.Globalization;

int n;
int[] vetor;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

vetor = new int[n]; ;

Console.WriteLine(); // para pular uma linha

Console.Write("Informe os valores na mesma linha separados por um espaço: ");
string[] s = Console.ReadLine().Split(' ');

Console.WriteLine(); // para pular uma linha

for (int i = 0; i < n; i++)
{
    vetor[i] = int.Parse(s[i]);
}

int quantidade = 0;

for (int i = 0; i < n; i++)
{
    if (vetor[i] % 2 == 0)
    {
        Console.Write(vetor[i] + " ");
        quantidade++;
    }
}

Console.WriteLine("\n\nForam encontrados " + quantidade + " números pares");