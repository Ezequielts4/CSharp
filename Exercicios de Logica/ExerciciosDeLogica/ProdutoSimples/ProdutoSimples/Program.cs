int a, b, prod;

Console.WriteLine("********Descubra o produto de dois números inteiros********");

Console.Write("Entre com o valor do primeiro número: ");
a = int.Parse(Console.ReadLine());

Console.Write("Entre com o valor do segundo número: ");
b = int.Parse(Console.ReadLine());

prod = a * b;

Console.WriteLine("PROD = " + prod);

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();