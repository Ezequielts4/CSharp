int a, b, c, d, diferenca;

Console.WriteLine("********Descubra a diferenca de quatro números inteiros********");

Console.Write("Insira o primeiro valor: ");
a = int.Parse(Console.ReadLine());

Console.Write("Insira o segundo valor: ");
b = int.Parse(Console.ReadLine());

Console.Write("Insira o terceiro valor: ");
c = int.Parse(Console.ReadLine());

Console.Write("Insira o quarto valor: ");
d = int.Parse(Console.ReadLine());

diferenca = (a * b - c * d);

Console.WriteLine("DIFERENCA = " + diferenca);

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();