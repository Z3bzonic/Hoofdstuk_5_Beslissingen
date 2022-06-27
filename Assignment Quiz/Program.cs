// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.BackgroundColor= ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

string[] vraag = new string[3];
string[] correct = new string[3];
bool[] resultaat = new bool[3];
string tempAntwoord;
string temp;

vraag[0] = ("Wat is 'Lupus lupus' uit de Latijnse taal");
const string antwoordA1 = "Wolf";
const string antwoordA2 = "Lepels";
const string antwoordA3 = "Faucet";
const string antwoordA4 = "Beer";
correct[0] = "A";

vraag[1] = "Hoeveel eieren zitten er in een dozijn";
const string antwoordB1 = "Geen, eieren zitten namelijk nooit";
const string antwoordB2 = "Twaalf";
const string antwoordB3 = "Vierentwintig";
const string antwoordB4 = "Zes";
correct[1] = "B";

vraag[2] = "Wat is een titratie.";
const string antwoordC1 = "Het bepalen van een gsm locatie door drie masten te laten 'pingen'.";
const string antwoordC2 = "Het vieren van een geweldige overwinning.";
const string antwoordC3 = "Moleculair gewicht mengen om een andere chemische oplossing te bekomen";
const string antwoordC4 = "Geen van bovenstaande.";
correct[2] = "C";

const string message = (@"
░██████╗░██╗░░░██╗██╗███████╗████████╗██╗███╗░░░███╗███████╗
██╔═══██╗██║░░░██║██║╚════██║╚══██╔══╝██║████╗░████║██╔════╝
██║██╗██║██║░░░██║██║░░███╔═╝░░░██║░░░██║██╔████╔██║█████╗░░
╚██████╔╝██║░░░██║██║██╔══╝░░░░░██║░░░██║██║╚██╔╝██║██╔══╝░░
░╚═██╔═╝░╚██████╔╝██║███████╗░░░██║░░░██║██║░╚═╝░██║███████╗
░░░╚═╝░░░░╚═════╝░╚═╝╚══════╝░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝╚══════╝");

// +++ main program +++

for (int i = 0; i < 3; i++)
{
// +++ main header +++
Console.WriteLine(message);

// +++ vraagstelling +++

Console.WriteLine($"Vraag 1: {vraag[i]}");
tempAntwoord=Console.ReadLine();
    if (tempAntwoord == correct[i])
    {
        resultaat[i] = true;
        Console.WriteLine("Goed beantwoord!");
    }
    else
    {
        resultaat[i] = false;
        Console.WriteLine("Niet juist!");
    }
    if (i != 2)
    {
        Console.WriteLine("Volgende vraag in 3 seconden!");
        Thread.Sleep(3000);
    }

    
    Console.Clear();
}

// +++ eindresultaat + juiste antwoorden
for (int i = 0; i < 3; i++)
{
    if (resultaat[i] == true)
    {
        temp = "Juist";
    }
    else
    {
        temp = "Fout";
    }
    Console.Write($"Vraag{i+1} was {temp} ");
}
// +++ console color reset +++
Console.ForegroundColor= ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;