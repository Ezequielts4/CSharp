using System.Globalization;

int n = int.Parse(Console.ReadLine());

string[] nomes = new string[n];
double[] compra = new double[n];
double[] venda = new double[n];

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    nomes[i] = valores[0];
    compra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
    venda[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
}

int contAbaixoDe10 = 0;
int contEntre10e20 = 0;
int contAcimaDe20 = 0;

for (int i = 0; i < n; i++)
{
    double lucro = venda[i] - compra[i];
    double PorcentagemDeLucro = lucro / compra[i] * 100;

    if (PorcentagemDeLucro < 10)
    {
        contAbaixoDe10++;
    }
    
    else if(PorcentagemDeLucro <= 20) 
    { 
        contEntre10e20++;
    }

    else
    {
       contAcimaDe20++;
    }
}

Console.WriteLine(); // para pular uma linha

Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10e20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

double totalDeCompra = 0.0;
double totalDeVenda = 0.0;

for (int i = 0; i < n; i++)
{
    totalDeCompra += compra[i];
    totalDeVenda += venda[i];
}

double totalDoLucro = totalDeVenda - totalDeCompra;

Console.WriteLine("Valor total de compra: " + totalDeCompra.ToString("F2", CultureInfo.InvariantCulture) + " reais");
Console.WriteLine("Valor total de venda: " + totalDeVenda.ToString("F2", CultureInfo.InvariantCulture) + " reais");
Console.WriteLine("Valor total de lucro: " + totalDoLucro.ToString("F2", CultureInfo.InvariantCulture) + " reais");

