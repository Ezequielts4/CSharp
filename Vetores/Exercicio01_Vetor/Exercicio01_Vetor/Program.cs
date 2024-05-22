using System.Globalization;

int n;
double[] vetor;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

vetor = new double[n]; ;

Console.WriteLine(); // para pular uma linha

Console.Write("Informe os valores: ");
string[] s = Console.ReadLine().Split(' ');


for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(s[i]);
}

Console.WriteLine(); // para pular uma linha

double maior = n;
int posicao = 0;


for (int i = 0; i < n; i++)
{
    if (vetor[i] > maior)
    {
        maior = vetor[i];
        posicao = i;
    }
}

Console.WriteLine("O " + maior + " é o maior número!");
Console.WriteLine("Ele está na " + posicao + "° posição!");

// arrumar o CultureInfo.InvariantCulture  e  arrumar o double dos numeros 