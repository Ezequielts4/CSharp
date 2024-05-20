using System.Globalization;

int a, b, c, maiorAB, maiorC, maior;

Console.WriteLine("Informe o primeiro valor: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro valor: ");
c = int.Parse(Console.ReadLine());

maiorAB = (a + b + Math.Abs(a - b)) / 2;

maiorC = (c + maiorAB + Math.Abs(c - maiorAB)) / 2;

maior = (maiorAB + maiorC + Math.Abs(maiorAB - maiorC)) / 2;

Console.WriteLine(maior + " eh o maior");


