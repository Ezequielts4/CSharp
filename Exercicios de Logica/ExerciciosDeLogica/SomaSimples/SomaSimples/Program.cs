int a, b, soma;

Console.WriteLine("********Descubra a soma de dois números inteiros********");

Console.Write("Entre com o valor do primeiro número: ");
a = int.Parse(Console.ReadLine());

Console.Write("Entre com o valor do segundo número: ");
b = int.Parse(Console.ReadLine());

soma = a + b;

Console.WriteLine("SOMA = " + soma);

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();
