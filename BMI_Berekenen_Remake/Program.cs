// See https://aka.ms/new-console-template for more information

// +++ Main input block +++
Console.WriteLine("Geef lengte in m");
float lengte = float.Parse(Console.ReadLine());
Console.WriteLine("Geef gewicht in kg");
float gewicht = (float)Convert.ToDouble(Console.ReadLine());
lengte = lengte * 2;
float bmi = (float)Math.Round((gewicht / lengte), 2);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"JE BMI is {bmi} \n");

// +++ Ouput color determination +++
string boodschap="";
if (bmi < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    boodschap = "Ondergewicht";
}
else if ((bmi > 18.5) && (bmi <= 24.9))
{
    Console.ForegroundColor = ConsoleColor.Green;
    boodschap = "normaal gewicht.";
}
else if ((bmi > 25) && (bmi <= 29.9))
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    boodschap = "overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.";
}
else if ((bmi > 30) && (bmi <= 39.9))
{
    Console.ForegroundColor = ConsoleColor.Red;
    boodschap = "Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.";
}
else if (bmi > 39.9)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    boodschap = "ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).";
}

// +++ Message feedback +++
Console.WriteLine(boodschap);


// +++ reset font color +++
Console.ForegroundColor=ConsoleColor.White;

