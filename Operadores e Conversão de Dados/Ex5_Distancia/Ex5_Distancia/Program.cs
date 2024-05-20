using System.Globalization;

double x, y, x1, y1, x2, y2, distancia;

Console.WriteLine("Informe o primeiro valor: ");
x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor: ");
y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro valor: ");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o quarto valor: ");
y2 = double.Parse(Console.ReadLine());

x = x2 - x1;
y = y2 - y1;

distancia = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));







