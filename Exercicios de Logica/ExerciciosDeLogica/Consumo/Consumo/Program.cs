int X;
double Y, CM;

Console.WriteLine("Insira a distância total percorrida: ");
X = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o total de combustível gasto: ");
Y = double.Parse(Console.ReadLine());

CM = X / Y;

Console.WriteLine("O consumo médio é de: " + CM.ToString("F3") + " km/l"); 

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();

