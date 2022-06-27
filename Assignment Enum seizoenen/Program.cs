// See https://aka.ms/new-console-template for more information
using Assignment_Enum_seizoenen;

Seizoenen keuze = Seizoenen.Default;
int maand = 13;

while (maand != 0)
{
    Console.WriteLine("Geef de maandnummer in");
    maand = int.Parse(Console.ReadLine());

switch (maand)
{
    case 1:
    case 2:
    case 3:
        keuze = (Seizoenen)Seizoenen.Winter ;
        break;
    case 4:
    case 5:
    case 6:
        keuze = Seizoenen.Lente;
        break;
    case 7:
    case 8:                                       
    case 9:
        break;
        keuze = Seizoenen.Zomer;
    case 10:
    case 11:
    case 12:
        keuze = (Seizoenen)5;
        break;
    default:
        break;
}
if ((keuze == Seizoenen.Winter) || (keuze == Seizoenen.Herfst))
{
    Console.WriteLine("Het is een koud seizoen");
}
if ((keuze == Seizoenen.Zomer) || (keuze == Seizoenen.Lente))
{
    Console.WriteLine("Het is een warm seizoen");
}

}
