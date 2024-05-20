int senha = 1234;

Console.Write("Insira a sua senha: ");
senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("ACESSO PERMITIDO");
}
else
{
    Console.WriteLine("ACESSO NEGADO");
}

Console.ReadLine();
