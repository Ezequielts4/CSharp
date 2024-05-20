using System.Globalization;

int idade;

Console.WriteLine("Informe a sua idade em dias: ");
idade = int.Parse(Console.ReadLine());

int x1 = idade / 365;
Console.WriteLine(x1 + " ano(s)");

int x2 = idade % 365 / 30;
Console.WriteLine(x2 + " mês(es)");

int x3 = idade % 365 % 30;
Console.WriteLine(x3 + " dia(s)");



