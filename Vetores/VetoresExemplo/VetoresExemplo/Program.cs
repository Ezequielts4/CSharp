

/*int n = int.Parse(Console.ReadLine());
double[] vetor = new double[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine());
}

for (int i = 0;i < n;i++)
{
    Console.WriteLine(vetor[i]);
}*/



/*exemplo - exemplo - exemplo - exemplo - exemplo - exemplo - exemplo*/

using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] vetores = new double[n];

string[] s = Console.ReadLine().Split(' ');


// for para leitura
for (int i = 0; i < n; i++)
{
    vetores[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
}  

// for para mostrar o vetor
for (int i = 0;i < n; i++)
{
    Console.Write(vetores[i] + " ");
    Console.WriteLine();
}


// for para os cálculos
double soma = 0.0;

for (int i = 0; i < n; i++)
{
    soma+= vetores[i];
}      

double media = soma / n;

Console.WriteLine(soma);
Console.WriteLine(media);

/*exemplo 2 - exemplo 2 - exemplo 2 - exemplo 2 - exemplo 2 - exemplo 2*/

/*using System.Globalization;

int n = int.Parse(Console.ReadLine());

Console.WriteLine();

string[] nomes = new string[n];
int[] idades = new int[n];
double[] alturas = new double[n];


// leitura dos dados
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
    alturas[i] = double.Parse(s[2]);
}

//calculo da altura media das pessoas

double soma = 0.0;

for (int i = 0; i < n; i++)
{
    soma += alturas[i];
}

Console.WriteLine();

double media = soma / n;

Console.WriteLine("Altura média: " + soma / n);

//porcentagem de pessoas abaixo de 16 anos

int cont = 0;

for (int i = 0; i < n; i++)
{
    if (idades[i] < 16)
    {
        cont++;
    }
}

double porcentagem = (double)cont / n * 100;
Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem + "%");
*/





