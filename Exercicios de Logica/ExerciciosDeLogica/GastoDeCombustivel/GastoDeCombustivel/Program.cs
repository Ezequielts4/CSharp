double H, Vm, D, litros;

Console.WriteLine("********Descubra quantos litros de combustível foram gastos na sua viagem!********");
Console.WriteLine("Insira o tempo gasto na viagem: ");
H = double.Parse(Console.ReadLine());

Console.WriteLine("Insira a velocidade média da viagem: ");
Vm = double.Parse(Console.ReadLine());

D = H * Vm;

litros = D / 12;

Console.WriteLine("Seriam gastos " + litros.ToString("F3") + " litros para a viagem."); 

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();
