using System.Globalization;

string nome;
double peso, altura, imc;

Console.WriteLine("Informe o seu nome: ");
nome = (Console.ReadLine());

Console.WriteLine("Informe o seu peso: ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a sua altura: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine(Math.Round(imc, 2));




