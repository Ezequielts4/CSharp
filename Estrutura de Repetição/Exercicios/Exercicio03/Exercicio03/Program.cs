Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine().ToLower();

int i = 0;
int j = palavra.Length - 1;

bool Palindromo = true;

while (i > j)
{
    if (palavra[i] != palavra[j])
    {
        Palindromo = false;
        break;
    }
    i++;
    j--;
}
if (Palindromo)
{
    Console.WriteLine("A palavra é palindromo");
}
else
{
    Console.WriteLine("A palavra não é um palindromo");
}
  
    

