int N, anos, meses, dias, resto;

N = int.Parse(Console.ReadLine());

Console.WriteLine(N);

anos = N / 365;
resto = N % 365;
meses = resto / 30;
dias = resto % 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(dias + " dia(s)");
