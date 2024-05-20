using System.Globalization;

double a, b, c;
double triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

Console.WriteLine("Informe primeiro valor: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Informe segundo valor: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Informe terceiro valor: ");
c = double.Parse(Console.ReadLine());

triangulo = a * c / 2;

circulo = pi * Math.Pow(c, 2);

trapezio = (a + b) * c / 2;

quadrado = Math.Pow(b, 2);

retangulo = a * b;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));

Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));

Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



