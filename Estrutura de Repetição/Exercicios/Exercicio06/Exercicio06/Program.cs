bool senha = false;

do
{
    Console.WriteLine("Digite a senha: ");
    string tentativa = Console.ReadLine();

    if (tentativa == "senha123")
    {
        Console.WriteLine("\nBem vindo! A senha está correta.");
        senha = true;
    }
    else
    {
        Console.WriteLine("\nSenha inválida...");
    }

} while (senha == false);