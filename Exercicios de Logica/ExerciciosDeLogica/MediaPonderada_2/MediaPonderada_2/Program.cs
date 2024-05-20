double a, b, c, media;

Console.WriteLine("********Descubra a sua média!********");
Console.Write("Insira a sua primeira nota: ");
a = double.Parse(Console.ReadLine());

Console.Write("Insira a sua segunda nota: ");
b = double.Parse(Console.ReadLine());

Console.Write("Insira a sua terceira nota: ");
c = double.Parse(Console.ReadLine());

media = (a * 2 + b * 3 + c * 5) / 10;

Console.WriteLine("MEDIA = " + media.ToString("F1"));

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();
