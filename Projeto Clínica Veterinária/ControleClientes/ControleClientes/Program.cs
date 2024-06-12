using ControleClientes;

float valPag;

Console.Write("Informe o nome: ");
string nome = Console.ReadLine();

Console.Write("Informe o endereço: ");
string endereco = Console.ReadLine();

Console.Write("Pessoa Física (F) ou  Pessoa Jurídica (J): ");
string tipo = Console.ReadLine().ToLower();

if (tipo == "f")
{
    PessoaFisica pf = new PessoaFisica();
    pf.Nome = nome;
    pf.Endereco = endereco;
    Console.Write("Informe o CPF: ");
    pf.Cpf = Console.ReadLine();

    Console.Write("Informe o RG: ");
    pf.Rg = Console.ReadLine();

    Console.Write("Informe o valor da compra: ");
    valPag = float.Parse(Console.ReadLine());

    pf.PagarImposto(valPag);

    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("-------- Pessoa Física --------");
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("Nome ..........: " + pf.Nome);
    Console.WriteLine("Endereço ......: " + pf.Endereco);
    Console.WriteLine("CPF ...........: " + pf.Cpf);
    Console.WriteLine("RG ............: " + pf.Rg);
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("Valor da compra: " + pf.Valor.ToString("C"));
    Console.WriteLine("Imposto .......: " + pf.ValorImposto.ToString("C"));
    Console.WriteLine("Total a pagar .: " + pf.Total.ToString("C"));
}

else if (tipo == "j")
{
    PessoaJuridica pj = new PessoaJuridica();
    pj.Nome = nome;
    pj.Endereco = endereco;
    Console.Write("Informe o CNPJ: ");
    pj.Cnpj = Console.ReadLine();
    Console.Write("Informe o IE: ");
    pj.Ie = Console.ReadLine();
    Console.Write("Informe o valor da compra: ");
    valPag = float.Parse(Console.ReadLine());

    pj.PagarImposto(valPag);

    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("-------- Pessoa Jurídica --------");
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("Nome ..........: " + pj.Nome);
    Console.WriteLine("Endereço ......: " + pj.Endereco);
    Console.WriteLine("CNPJ ...........: " + pj.Cnpj);
    Console.WriteLine("IE ............: " + pj.Ie);
    Console.WriteLine(); // para pular uma linha
    Console.WriteLine("Valor da compra: " + pj.Valor.ToString("C"));
    Console.WriteLine("Imposto .......: " + pj.ValorImposto.ToString("C"));
    Console.WriteLine("Total a pagar .: " + pj.Total.ToString("C"));
}

else
{
    Console.WriteLine("Entrada Inválida!");
}
