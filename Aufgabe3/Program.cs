// Aufgabe 3
int erg = 0;
int durch = 0;

Console.WriteLine("Wie viele Zahlen wollen Sie zusammen addieren?");
int amount = Convert.ToInt32(Console.ReadLine());
int[] zahlen = new int[amount];
for (int i = 0; i < zahlen.Length; i++)
{
    Console.WriteLine("Geben Sie die " + (i + 1) + ". Zahl an:");
    zahlen[i] = Convert.ToInt32(Console.ReadLine());
    erg = erg + zahlen[i];
    durch = erg / amount;
}

Console.WriteLine("Das Ergebniss lautet: " + erg);
Console.WriteLine("Der Durchschnitswert beträgt: " + durch);
Console.WriteLine("Die kleinste eingegebene Zahl lautet: " + zahlen.Min());
Console.WriteLine("Die größte eingegebene Zahl lautet: " + zahlen.Max());


