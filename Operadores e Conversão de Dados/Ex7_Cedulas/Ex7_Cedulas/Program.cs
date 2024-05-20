using System.Globalization;

int valor;

Console.WriteLine("Informe um valor: ");
valor = int.Parse(Console.ReadLine());

int x1 = valor / 100;
Console.WriteLine(x1 + " notas(s) de R$ 100,00");

int x2 = valor % 100 / 50;
Console.WriteLine(x2 + " notas(s) de R$ 50,00");

int x3 = valor % 100 % 50 / 20;
Console.WriteLine(x3 + " notas(s) de R$ 20,00");

int x4 = valor % 100 % 50 % 20 / 10;
Console.WriteLine(x4 + " notas(s) de R$ 10,00");

int x5 = valor % 100 % 50 % 20 % 10 / 5;
Console.WriteLine(x5 + " notas(s) de R$ 5,00");

int x6 = valor % 100 % 50 % 20 % 10 % 5 / 2;
Console.WriteLine(x6 + " notas(s) de R$ 2,00");

int x7 = valor % 100 % 50 % 20 % 10 % 5 % 2 / 1;
Console.WriteLine(x7 + " moeda(s) de R$ 1,00");








