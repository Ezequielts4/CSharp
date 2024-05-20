
Console.Write("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());
int soma = 0;
int i = 2;

while (i <= num)
{
    soma += i;
    i += 2;
}

Console.WriteLine("A soma dos números pares é: " + soma);

