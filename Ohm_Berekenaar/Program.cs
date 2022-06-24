// See https://aka.ms/new-console-template for more information
double spanning;
double weerstand;
double stroom;

Console.WriteLine("Wat wens je te berekenen (kies met de getoonde letter gevold door een enter):\nA: Stroomsterkte\nB: Spanning\nC: Weerstand");
string keuze = Console.ReadLine();
// stroom = spanning/weerstand - spanning = stroom * weerstand - weerstand = spanning / stroom

switch (keuze)
{
    case "A":
        Console.WriteLine("Geef de spanning op");
            spanning = double.Parse(Console.ReadLine());
        Console.WriteLine("Geef de weerstand op");
            weerstand = double.Parse(Console.ReadLine());
        Console.WriteLine($"stroom = {Math.Round( (spanning / weerstand) , 2 )}");
        return;

    case "B":
        Console.WriteLine("Geef de stroom op");
            stroom = double.Parse(Console.ReadLine());
        Console.WriteLine("Geef de weerstand op");
            weerstand = double.Parse(Console.ReadLine());
        Console.WriteLine($"spanning = {Math.Round((stroom * weerstand),2)}");
        return;

    case "C":
        Console.WriteLine("Geef de spanning op");
            spanning = double.Parse(Console.ReadLine());
        Console.WriteLine("Geef de weerstand op");
            stroom = double.Parse(Console.ReadLine());
        Console.WriteLine($"weerstand = {Math.Round((spanning / stroom),2)}");
        return;

    default:
        Console.WriteLine("Onjuiste keuze .... Exiting");
        break;
}