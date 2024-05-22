using System.Globalization;

int n, contagem = 0;
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

int soma = 0;
double media;

for (int i = 0; i < n; i++)
{
    if (vetor[i] % 2 == 0)
    {
        soma += vetor[i];
        contagem++;
    }
}

media = soma / contagem;

Console.WriteLine("A média é: " + media);