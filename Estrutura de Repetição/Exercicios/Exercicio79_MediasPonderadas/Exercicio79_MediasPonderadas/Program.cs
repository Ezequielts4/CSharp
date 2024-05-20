using System.Globalization;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(" ");
    double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
    double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
    double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}