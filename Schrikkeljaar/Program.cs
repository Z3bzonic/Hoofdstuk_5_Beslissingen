// See https://aka.ms/new-console-template for more information
Console.WriteLine("Voer een jaartal in");
int jaar = int.Parse(Console.ReadLine());

if ((jaar % 4 == 0) && ((jaar % 100 != 0) || (jaar % 400 == 0)))
{
    Console.WriteLine($"Jaar {jaar} is een schrikkeljaar");
}
else
{
    Console.WriteLine($"Jaar {jaar} is geen schrikkeljaar");
}
