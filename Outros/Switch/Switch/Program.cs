int diaDaSemana = int.Parse(Console.ReadLine());
string dia;

switch (diaDaSemana)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Segunda";
        break;
    case 3:
        dia = "Terça";
        break;
    case 4:
        dia = "Quarta";
        break;
    case 5:
        dia = "Quinta";
        break;
    case 6:
        dia = "Sexta";
        break;
    case 7:
        dia = "Sabado";
        break;
    default:
        dia = "Valor inválido";
        break;
}
Console.WriteLine("Dia da semana: " + dia);