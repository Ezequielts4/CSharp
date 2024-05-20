using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] vetores = new double[n];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    vetores[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
}

for (int i = 0; i < n; i++)
{
    Console.Write(vetores[i]);
}
