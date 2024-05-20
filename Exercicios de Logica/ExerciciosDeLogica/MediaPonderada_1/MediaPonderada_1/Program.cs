double a, b, media;

Console.WriteLine("********Descubra sua a média!********");
Console.WriteLine("Insira a sua primeira nota: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a sua segunda nota: ");
b = double.Parse(Console.ReadLine());

media = (a * 3.5 + b * 7.5) / 11;

Console.WriteLine("MEDIA = " + media.ToString("F5"));

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();