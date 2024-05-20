

Console.WriteLine("Responda com Sim ou Não");

Console.WriteLine("\nTelefonou para a vítima?");
string r1 = Console.ReadLine().ToLower();

Console.WriteLine("Esteve no local do crime?");
string r2 = Console.ReadLine().ToLower();

Console.WriteLine("Mora perto da vítima?");
string r3 = Console.ReadLine().ToLower();

Console.WriteLine("Devia para a vítima?");
string r4 = Console.ReadLine().ToLower();

Console.WriteLine("Já trabalhou com a vítima?");
string r5 = Console.ReadLine().ToLower();

int contagem = 0;

if (r1 == "sim")
{
    contagem = 1;
}

if (r2 == "sim")
{
    contagem = contagem + 1;
}

if (r3 == "sim")
{
    contagem = contagem + 1;
}

if (r4 == "sim")
{
    contagem = contagem + 1;
}

if (r5 == "sim")
{
    contagem = contagem + 1;
}

if (contagem == 2)
{
    Console.WriteLine("Suspeito");
}

else if (contagem > 2 && contagem < 5)
{
    Console.WriteLine("Cúmplice");
}

else if (contagem == 5)
{
    Console.WriteLine("Culpado");
}

else
{
    Console.WriteLine("Inocente");
}

Console.ReadKey();