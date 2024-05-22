using System.Globalization;

int n;
int[] s;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

s = new int[n];

Console.WriteLine(); // para pular uma linha

string[] nome = new string[n];
double[] precoCompra = new double[n];
double[] precoVenda = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Informe o nome do produto, seu preço de compra e o seu preço de venda: ");
    string[] x = Console.ReadLine().Split(' ');

    nome[i] = x[0];
    precoCompra[i] = double.Parse(x[1], CultureInfo.InvariantCulture);
    precoVenda[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
}

Console.WriteLine(); // para pular uma linha

for (int i = 0; i < n; i++)
{
    Console.WriteLine(nome[i]);
    Console.WriteLine(precoCompra[i]);
    Console.WriteLine(precoVenda[i]);
}


