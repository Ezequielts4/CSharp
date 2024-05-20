string p1, p2, p3;

Console.WriteLine("********DESCUBRA O TIPO DE ANIMAL********");
Console.WriteLine("\n********insira apenas letras minúsculas********");

Console.WriteLine("\nInsira a primeira palavra: ");
p1 = Console.ReadLine();

Console.WriteLine("\nInsira a segunda palavra: ");
p2 = Console.ReadLine();

Console.WriteLine("\nInsira a terceira palavra: ");
p3 = Console.ReadLine();


if (p1 == "vertebrado" && p2 == "ave" && p3 == "carnivoro")
{
    Console.WriteLine("\nÁguia");
}

else if (p1 == "vertebrado" && p2 == "ave" && p3 == "onivoro")
{
    Console.WriteLine("\nPomba");
}

else if (p1 == "vertebrado" && p2 == "mamifero" && p3 == "onivoro")
{
    Console.WriteLine("\nHomem");
}

else if (p1 == "vertebrado" && p2 == "mamifero" && p3 == "herbivoro")
{
    Console.WriteLine("\nVaca");
}

if (p1 == "invertebrado" && p2 == "inseto" && p3 == "hematofago")
{
    Console.WriteLine("\nPulga");
}

else if (p1 == "invertebrado" && p2 == "inseto" && p3 == "herbivoro")
{
    Console.WriteLine("\nLagarta");
}

else if (p1 == "invertebrado" && p2 == "anelideo" && p3 == "hematofago")
{
    Console.WriteLine("\nSanguessuga");
}

else if (p1 == "invertebrado" && p2 == "anelideo" && p3 == "onivoro")
{
    Console.WriteLine("\nMinhoca");
}

else
{
    Console.WriteLine("\nAnimal não encontrado...");
}

Console.ReadKey();
