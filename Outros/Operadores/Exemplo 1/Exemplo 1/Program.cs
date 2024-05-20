using System.Globalization;

double b, a, area, perimetro, diagonal;

b = double.Parse(Console.ReadLine());
a = double.Parse(Console.ReadLine());

area = b * a;
perimetro = 2 * (b + a);
diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

Console.WriteLine("Area: " + area);
Console.WriteLine("Perimetro: " + perimetro);
Console.WriteLine("Diagonal: " + diagonal.ToString("F4", CultureInfo.InvariantCulture));