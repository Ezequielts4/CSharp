using System.Globalization;

int n;
int[] s;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

s = new int[n];

Console.WriteLine(); // para pular uma linha

string[] nomes = new string[n];
double[] nota1 = new double[n];
double[] nota2 = new double[n];


for (int i = 0; i < n; i++) { 
Console.Write("Informe o seu nome, sua nota do primeiro e do segundo semestre, respectivamente: ");
string[] x = Console.ReadLine().Split(' ');

nomes[i] = x[0];
nota1[i] = double.Parse(x[1], CultureInfo.InvariantCulture);
nota2[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
}

Console.WriteLine(); // para pular uma linha

Console.WriteLine("Alunos aprovados: ");

for (int i = 0; i < n; i++)
{
    if ((nota1[i] + nota2[i]) / 2 >= 6)
    {
        Console.WriteLine(nomes[i]);
    }
}

// arrumar o cultureInfo




