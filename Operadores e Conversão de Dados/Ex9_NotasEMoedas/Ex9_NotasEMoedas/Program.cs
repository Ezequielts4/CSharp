using System.Globalization;

double valor;

Console.WriteLine("Informe um valor: ");
valor = double.Parse(Console.ReadLine());

Console.WriteLine("\nNOTAS:");

double x1 = valor / 100;
Console.WriteLine(x1.ToString("F0") + " notas(s) de R$ 100,00");

double x2 = valor % 100 / 50;
Console.WriteLine(x2.ToString("F0") + " notas(s) de R$ 50,00");

double x3 = valor % 100 % 50 / 20;
Console.WriteLine(x3.ToString("F0") + " notas(s) de R$ 20,00");

double x4 = valor % 100 % 50 % 20 / 10;
Console.WriteLine(x4.ToString("F0") + " notas(s) de R$ 10,00");

double x5 = valor % 100 % 50 % 20 % 10 / 5;
Console.WriteLine(x5.ToString("F0") + " notas(s) de R$ 5,00");

double x6 = valor % 100 % 50 % 20 % 10 % 5 / 2;
Console.WriteLine(x6.ToString("F0") + " notas(s) de R$ 2,00");

Console.WriteLine("\nMOEDAS:");

double x7 = valor % 100 % 50 % 20 % 10 % 5 % 2 / 1;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 1,00");

double x8 = valor % 100 % 50 % 20 % 10 % 5 % 2 % 1 / 0.50;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 0.50");

double x9 = valor % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 / 0.25;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 0.25");

double x10 = valor % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 / 0.10;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 0.10");

double x11 = valor % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 / 0.05;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 0.05");

double x12 = valor % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.50 % 0.25 % 0.10 % 0.05 / 0.01;
Console.WriteLine(x7.ToString("F0") + " moeda(s) de R$ 0.01");


