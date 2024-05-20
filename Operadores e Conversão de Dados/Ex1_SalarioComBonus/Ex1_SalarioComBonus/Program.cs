using System.Globalization;

string nome;
double salario, vendas, comissao, total;

Console.WriteLine("Informe o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Informe o seu salário: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total de suas vendas: ");
vendas = double.Parse(Console.ReadLine());

comissao = vendas * 0.15;
total = salario + comissao;

Console.WriteLine("Total: " + total.ToString("F2", CultureInfo.InvariantCulture));




