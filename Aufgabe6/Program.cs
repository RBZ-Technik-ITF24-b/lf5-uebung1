// Aufgabe 6

Console.Write("Zaunfläche in m2: ");
int area;
while (!int.TryParse(Console.ReadLine(), out area))
{
    Console.WriteLine("Bitte eine ganze Zahl eingeben.");
    Console.Write("Zaunfläche in m2: ");
}

int minWidth = 0;
int minLength = 0;
int totalLength = int.MaxValue;
for (int i = 1; i <= 80; i++)
{
    int length = area / i;

    if (length <= 80 && (2 * i + length) < totalLength)
    {
        minWidth = i;
        minLength = length;
        totalLength = 2 * i + length;
    }
}

Console.WriteLine($"Mit einer Breite von {minWidth}m und einer Länge von {minLength}m wird die kleinste Zaunlänge von {totalLength}m erreicht.");