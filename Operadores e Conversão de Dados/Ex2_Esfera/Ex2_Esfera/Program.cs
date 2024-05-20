using System.Globalization;

double raio, pi = 3.14159, volume;

Console.WriteLine("Informe o raio: ");
raio = double.Parse(Console.ReadLine());

volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


