// Aufgabe 7 Primzahlen

for (int i = 1; i <= 100; i++)
{
    bool prime = true;
    for (int j = 2; j < i; j++)
    {
        if ((i % j) == 0) prime = false;
    }
    if (prime) Console.WriteLine(i);
}