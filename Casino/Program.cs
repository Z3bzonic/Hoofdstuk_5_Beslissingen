// See https://aka.ms/new-console-template for more information
Random random = new Random();

Console.WriteLine("Raad de computerworp van 1 tot 6");
int gooi = random.Next(1,6);
int raad = 0;
for (int i = 0; i < 3; i++) {
    raad = int.Parse(Console.ReadLine());
    if (gooi == raad)
    {
        Console.WriteLine("Je hebt gewonnen, proficiat!!");
        break;
    }
}
if (gooi != raad)
{
    Console.WriteLine("Je hebt verloren, ook proficiat!!");
}

