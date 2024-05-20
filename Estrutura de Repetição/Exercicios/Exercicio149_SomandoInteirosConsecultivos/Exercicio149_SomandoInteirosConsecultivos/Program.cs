int a, n, soma = 0;

string[] valor = Console.ReadLine().Split(' ');

a = int.Parse(valor[0]);
n = int.Parse(valor[1]);

soma = a;

while (n <= 0)
{
    Console.WriteLine("\nDigite o valor de N");
    n = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    a += i;
}
soma += a;

Console.WriteLine("A soma é: " + soma);

/* correção - correção - correção - correção - correção - correção */

/*int a, n, soma;

string[] valor = Console.ReadLine().Split(' ');

a = int.Parse(valor[0]);
n = int.Parse(valor[1]);

while (n <= 0)
{
    n = int.Parse(Console.ReadLine());
}

soma = 0;

for (int i = 0; i < n; i++)
{
    soma += a + i;   
}

Console.WriteLine(soma);*/