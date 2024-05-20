using System.Globalization;

double n1, n2, n3, n4, media, mediaFinal, exame;

Console.Write("********DESCUBRA A SUA MÉDIA********");

Console.Write("\nInsira a sua primeira nota: ");
n1 = double.Parse(Console.ReadLine());

Console.Write("\nInsira a sua segunda nota: ");
n2 = double.Parse(Console.ReadLine());

Console.Write("\nInsira a sua terceira nota: ");
n3 = double.Parse(Console.ReadLine());

Console.Write("\nInsira a sua quarta nota: ");
n4 = double.Parse(Console.ReadLine());

media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

Console.WriteLine("\nMédia: " + media.ToString("F1", CultureInfo.InvariantCulture));

if (media >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}

else if (media >= 5 && media <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    Console.Write("\nInsira a nota do exame: ");
    exame = double.Parse(Console.ReadLine());

    mediaFinal = (media + exame) / 2;

    if (mediaFinal >= 5)
    {
        Console.WriteLine("\nMédia Final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Aluno aprovado");
    }
    else
    {
        Console.WriteLine("\nMédia Final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Aluno reprovado");
    }
}

else
{
    Console.WriteLine("Aluno reprovado.");
}

Console.ReadKey();
