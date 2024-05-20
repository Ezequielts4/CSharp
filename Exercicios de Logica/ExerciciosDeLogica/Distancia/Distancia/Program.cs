int km, t;

Console.WriteLine("********Descubra o tempo necessário para tomar distância do primeiro carro********");
Console.WriteLine("Insira a distância percorrida: ");
km = int.Parse(Console.ReadLine());

t = km * 2;

Console.WriteLine("O tempo necessário seria de " + t + " minutos.");

Console.WriteLine("Pressione Enter para sair...");
Console.ReadKey();
