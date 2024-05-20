double pi, raio, area;

Console.WriteLine("Informe o valor do raio da circunferência: ");
raio = double.Parse(Console.ReadLine());

pi = 3.14159;

area = pi * (raio * 2);

Console.WriteLine("A = " + area.ToString("F4"));

Console.ReadKey();

