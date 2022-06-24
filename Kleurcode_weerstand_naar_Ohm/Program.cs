// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] kleuren = new string[3];
for (int i = 0; i < 3; i++) {
    Console.WriteLine("Geef de eerste ringkleur op in kleine letters\n mogelijk keuzes: zwart / bruin / rood / oranje / geel / groen / blauw / paars / grijs / wit / goud / zilver");
    kleuren[i] = Console.ReadLine();

}
Console.Write("\n|----------------------|\n");
Console.Write("|--");
for (int i = 0; i < 3; i++)
{
    Console.Write($"-- {kleuren[i]}");
}
Console.Write("--|");

int band1=0;
switch (kleuren[0])
{
    case "zwart":
        band1 = 0;
        break;
    case "bruin":
        band1 = 1;
        break;
    case "rood":
        band1 = 2;
        break;
    case "oranje":
        band1 = 3;
        break;
    case "geel":
        band1 = 4;
        break;
    case "groen":
        band1 = 5;
        break;
    case "blauw":
        band1 = 6;
        break;
    case "paars":
        band1 = 7;
        break;
    case "grijs":
        band1 = 8;
        break;
    case "wit":
        band1 = 9;
        break;
    case "goud":
    case "zilver":
    default:
        Console.WriteLine("Onjuiste ingave, herstart programma");
        break;
}
int band2=0;
switch (kleuren[1])
{
    case "zwart":
        band2 = 0;
        break;
    case "bruin":
        band2 = 1;
        break;
    case "rood":
        band2 = 2;
        break;
    case "oranje":
        band2 = 3;
        break;
    case "geel":
        band2 = 4;
        break;
    case "groen":
        band2 = 5;
        break;
    case "blauw":
        band2 = 6;
        break;
    case "paars":
        band2 = 7;
        break;
    case "grijs":
        band2 = 8;
        break;
    case "wit":
        band2 = 9;
        break;
    case "goud":
    case "zilver":
    default:
        Console.WriteLine("Onjuiste ingave, herstart programma");
        break;
}

double band3 = 0;
switch (kleuren[2])
{
    case "zwart":
        band3 = 1;
        break;
    case "bruin":
        band3 = 10;
        break;
    case "rood":
        band3 = 100;
        break;
    case "oranje":
        band3 = 1000;
        break;
    case "geel":
        band3 = 10000;
        break;
    case "groen":
        band3 = 100000;
        break;
    case "blauw":
        band3 = 1000000;
        break;
    case "paars":
        band3 = 10000000;
        break;
    case "grijs":
        band3 = 100000000;
        break;
    case "wit":
        band3 = 1000000000;
        break;
    case "goud":
        band3 = 0.1;
        break;
    case "zilver":
        band3 = 0.01;
        break;
    default:
        Console.WriteLine("Onjuiste ingave, herstart programma");
        break;
}
double uitkomst = ((band1 * 10) + band2) * band3;
Console.WriteLine($"\n\nDe weerstand is {uitkomst} Ω");

// de oefening kan volgens mij beter door de uitkomt te herleiden naar een eenvoudiger cijfer met M K en G suffix
// in deze oefening heb ik wat moeite gehad met break omdat ik dacht dat breaks het programma beindigden had ik return gebruikt, nog te testen = goto