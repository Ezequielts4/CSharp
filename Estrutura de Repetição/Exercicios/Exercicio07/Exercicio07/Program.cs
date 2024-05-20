int randNum, chute, tentativa = 0;

randNum = new Random().Next(1, 101);

/*Console.WriteLine(randNum);*/ // para saber qual número está sendo gerado

do
{
    Console.WriteLine("Tente advinhar o número: ");
    chute = int.Parse(Console.ReadLine());

    if (chute < randNum)
    {
        Console.WriteLine("\nDigite um número maior!");
    }

    else if (chute > randNum)
    {
        Console.WriteLine("\nDigite o número menor!");
    }

    else
    {
        Console.WriteLine("\nVocê acertou!");
    }

    tentativa++;
}

while (chute != randNum);

Console.WriteLine("Parabéns! Você adivinhou o número em " + tentativa + " tentativas.");