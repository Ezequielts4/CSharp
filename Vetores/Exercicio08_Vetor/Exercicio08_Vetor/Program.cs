using System.Globalization;

int n;
int[] s;

Console.Write("Insira o valor de N: ");
n = int.Parse(Console.ReadLine());

s = new int[n];

Console.WriteLine(); // para pular uma linha

double[] alturas = new double[n];
string[] sexo = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Informe a sua altura e o seu sexo (F ou M): ");
    string[] x = Console.ReadLine().Split(' ');

    alturas[i] = double.Parse(x[0], CultureInfo.InvariantCulture);
    sexo[i] = x[1];
}

Console.WriteLine(); // para pular uma linha

double maior = 0;

for (int i = 0; i < n; i++)
{
    if (alturas[i] > maior)
    {
        maior = alturas[i];
    }
}

Console.WriteLine("A maior altura é: " + maior);


double menor = maior;

for (int i = 0; i < n; i++)
{
    if (alturas[i] < maior)
    {
        maior = alturas[i];
        menor = alturas[i];
    }
}

Console.WriteLine("A menor altura é: " + menor);

double media = 0;
int cont = 0;

for (int i = 0; i < n; i++)
{
    if (sexo[i] == "M" || sexo[i] == "m")
    {
        cont++;
        media = alturas[i] + alturas[i+1] / cont;
    }
}

Console.WriteLine("A média das mulheres é: " + media); 

int contagem = 0;

for (int i = 0; i < n; i++)
{
    if (sexo[i] == "M" || sexo[i] == "m")
    {
        contagem++;
    }
}

Console.WriteLine("Números de homens: " + contagem);


// arrumar a média das mulheres