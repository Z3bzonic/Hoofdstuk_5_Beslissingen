// See https://aka.ms/new-console-template for more information

// ++ declaratie +++


int kortingDenominator;
int aantal;
int totaal;

// ++ invoer +++

Console.WriteLine("Geef het aantal in om korting te bekomen");
kortingDenominator = int.Parse((Console.ReadLine()));
Console.WriteLine($"De gekozen korting is {kortingDenominator}");

Console.WriteLine("Geef het aantal schoenparen in");
aantal = int.Parse((Console.ReadLine()));

// ++ berekening van bedrag +++

if (aantal > kortingDenominator)
{
    totaal = kortingDenominator*20;
    totaal = totaal + ((aantal - kortingDenominator)*10);
}
else
{
    totaal = aantal * 20;
}

Console.WriteLine(totaal);