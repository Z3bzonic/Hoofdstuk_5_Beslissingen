// See https://aka.ms/new-console-template for more information

Random random = new Random();
Random fakeRandom = new Random();

Console.WriteLine(@" ________  ________  ________  ________  ___       _______      
|\   __  \|\   __  \|\   __  \|\   ____\|\  \     |\  ___ \     
\ \  \|\  \ \  \|\  \ \  \|\  \ \  \___|\ \  \    \ \   __/|    
 \ \  \\\  \ \   _  _\ \   __  \ \  \    \ \  \    \ \  \_|/__  
  \ \  \\\  \ \  \\  \\ \  \ \  \ \  \____\ \  \____\ \  \_|\ \ 
   \ \_______\ \__\\ _\\ \__\ \__\ \_______\ \_______\ \_______\
    \|_______|\|__|\|__|\|__|\|__|\|_______|\|_______|\|_______|");
Console.WriteLine(@" ________  _______   ___       ________  ___  ___  ___     
|\   ___ \|\  ___ \ |\  \     |\   __  \|\  \|\  \|\  \    
\ \  \_|\ \ \   __/|\ \  \    \ \  \|\  \ \  \\\  \ \  \   
 \ \  \ \\ \ \  \_|/_\ \  \    \ \   ____\ \   __  \ \  \  
  \ \  \_\\ \ \  \_|\ \ \  \____\ \  \___|\ \  \ \  \ \  \ 
   \ \_______\ \_______\ \_______\ \__\    \ \__\ \__\ \__\
    \|_______|\|_______|\|_______|\|__|     \|__|\|__|\|__|");
Console.WriteLine("Man(Y) of Vrouw?(X)");
string geslacht = Console.ReadLine();
Console.WriteLine("Geef je huidige leeftijd");
int leeftijd = int.Parse(Console.ReadLine());
int tijdOver=0;
Console.Clear();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(fakeRandom.Next(0,150));
    Thread.Sleep(20);
    Console.WriteLine(" || ");
    Thread.Sleep(20);
    Console.WriteLine(" || ");
    Thread.Sleep(20);
    Console.WriteLine(" || ");
    Thread.Sleep(20);
    Console.WriteLine(" || ");
    Thread.Sleep(20);
    Console.WriteLine(" || ");
    Thread.Sleep(20);
    Console.WriteLine("\\||/");
    Thread.Sleep(20);
    Console.WriteLine("  ° ");
    Thread.Sleep(20);
    Console.Clear();
}

switch (geslacht)
{
    case "Y":
        tijdOver = (random.Next(0,150 - leeftijd));
        break;
    case "X":
        tijdOver = (random.Next(0, 120 - leeftijd));
        break;
    default:
        Console.WriteLine("ongeldige keuze");
        break;
}
Console.WriteLine(" || ");
Console.WriteLine(" || ");
Console.WriteLine(" || ");
Console.WriteLine(" || ");
Console.WriteLine(" || ");
Console.WriteLine("\\||/");
Console.WriteLine("  ° ");
Console.WriteLine($"Deze invoer heeft nog {tijdOver} jaren te leven.");
