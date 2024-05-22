using System.Globalization;

int n;
int[] vetorC;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

vetorC = new int[n]; ;

Console.WriteLine(); // para pular uma linha

Console.Write("Informe os valores do primeiro vetor: ");
string[] x = Console.ReadLine().Split(' ');

Console.WriteLine(); // para pular uma linha

Console.Write("Informe os valores do segundo vetor: ");
string[] y = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    vetorC[i] = int.Parse(x[i]) + int.Parse(y[i]);
}

Console.WriteLine();// para pular uma linha

Console.Write("Os valores do terceiro vetor são: ");

for (int i = 0; i < n; i++)
{
    Console.Write(vetorC[i] + " ");
}