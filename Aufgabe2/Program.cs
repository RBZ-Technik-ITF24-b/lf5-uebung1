// Aufgabe 2
Console.WriteLine("Geben Sie die Zahl an, bis zu der die Teilbarkeit durch 3 getestet werden soll. (Ganzzahlen)");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gefundene Zahlen: ");
for (int i = 0; i <= max; i++)
{
    if ((i % 3) == 0)
    {
        Console.WriteLine(i.ToString());
    }
}