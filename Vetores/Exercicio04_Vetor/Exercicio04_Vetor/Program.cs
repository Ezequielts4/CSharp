using System.Globalization;

int n;
double[] vetor;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

vetor = new double[n]; ;

Console.WriteLine(); // para pular uma linha

Console.Write("Informe os valores na mesma linha separados por um espaço: ");
string[] s = Console.ReadLine().Split(' ');

Console.WriteLine(); // para pular uma linha

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(s[i]);
}

double soma = 0;
double media;

for (int i = 0; i < n; i++)
{
    soma += vetor[i];
}

media = soma / n;

Console.WriteLine("A média dos valores é: " + media);
Console.Write("\nEstão abaixo da média os números: ");

for (int i = 0; i < n; i++)
{
    if (vetor[i] < media)
    {
        Console.Write(vetor[i] + " ");
    }
}

// arrumar o cultureInfo