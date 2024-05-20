string letra;

Console.Write("Insira uma letra: ");
letra = Console.ReadLine();


if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U" || letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine("\nA letra é uma vogal");
}

else
{
    Console.WriteLine("\nA letra é uma consoante");
}

Console.ReadKey();
