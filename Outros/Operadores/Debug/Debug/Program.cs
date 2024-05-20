using System.Globalization;

double largura, comprimento, precoMetroQuadrado, area, preco;

largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = largura * comprimento;

preco = area * precoMetroQuadrado;

Console.WriteLine("Area = " + area.ToString("F2"), CultureInfo.InvariantCulture);
Console.WriteLine("Preço = " + preco.ToString("F2"), CultureInfo.InvariantCulture);