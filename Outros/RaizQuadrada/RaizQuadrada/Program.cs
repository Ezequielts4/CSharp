Console.WriteLine("********  Descubra a raiz quadrada de um número!!!  ******** ");
Console.Write("Entre com o valor de um número para calcular a Raiz: ");

double x = double.Parse(Console.ReadLine());
double y = Math.Sqrt(x);

Console.WriteLine("A raiz quadrada de " + x + " é igual a: " + y);
Console.WriteLine("Pressione qualquer tecla para sair...");

Console.ReadKey();
