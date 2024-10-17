// Aufgabe 5: Kapital

int duration;
float capital, interestRate, interest;

do
{
    Console.WriteLine("Wie viel Kapital haben Sie zur verüfugung?");
    capital = Convert.ToInt32(Console.ReadLine());
    if (capital < 1000) { Console.WriteLine("Das Kapital muss über 1000 Euro liegen."); }
} while (capital < 1000);

do
{
    Console.WriteLine("Wie lange (in Jahren) möchten Sie anlegen?");
    duration = Convert.ToInt32(Console.ReadLine());
    if (duration < 1) { Console.WriteLine("Die Mindestdauer beträgt ein Jahr"); }
} while (duration < 1);

Console.WriteLine("Wie hoch ist der Zinssatz (zwei Kommastellen)");
interestRate = float.Parse(Console.ReadLine());

for (int i = 0; i < duration; i++)
{
    interest = capital * (interestRate / 100);
    Console.WriteLine($"Jahr {(i + 1)}:\n     Kapital zum Jahresbeginn: {capital.ToString("0.00")} Euro\n     Zinsen: {interest.ToString("0.00")} Euro");
    capital = capital + interest;
}

