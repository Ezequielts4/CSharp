using System.Globalization;

int minutos;
double conta;

minutos = int.Parse(Console.ReadLine());

conta = 50.0;

if (minutos > 100)
{
    conta += (minutos - 100) * 2.0;
}

Console.WriteLine("Valor à pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));