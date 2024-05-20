
float salario, gastos;

Console.Write("Insira o valor do seu salario: ");
salario = float.Parse(Console.ReadLine());

Console.Write("Insira o valor dos seus gastos: ");
gastos = float.Parse(Console.ReadLine());


if (salario > gastos)
{
    Console.WriteLine("\nGastos dentro do orçamento");
}
else
{
    Console.WriteLine("\nOrçamento estourado");
}

Console.ReadLine();