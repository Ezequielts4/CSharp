int f, ht;
double vh, salario;


Console.WriteLine("Insira o seu número de identificação: ");
f = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o número das suas horas trabalhadas: ");
ht = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da sua hora trabalhada: ");
vh = double.Parse(Console.ReadLine());

salario = ht * vh;

Console.WriteLine("Número = " + f);
Console.WriteLine("Salário = R$ " + salario.ToString("F2"));

Console.WriteLine("Pressione Enter para sair...");

Console.ReadKey();
