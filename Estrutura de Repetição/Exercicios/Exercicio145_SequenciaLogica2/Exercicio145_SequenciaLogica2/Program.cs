
string[] valores = Console.ReadLine().Split(' ');

int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

Console.WriteLine();

for (int i = 1; i <= y; i++)
{
    Console.Write(i);

    if (i % x == 0)
    {
        Console.WriteLine();
    }

    else
    {
        Console.Write(" ");
    }
}

/* outra forma - outra forma - outra forma - outra forma */

/*for (int i = 1; i <= y; i++)
{

    if (i % x == 0)
    {
        Console.WriteLine(i);
    }

    else
    {
        Console.Write(i + " ");
    }
}
*/
