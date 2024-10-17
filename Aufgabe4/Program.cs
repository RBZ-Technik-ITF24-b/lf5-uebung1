// Aufgabe 4

int day;
int month;
int year;
int maxDays = 0;
bool isLeapYear;

Console.WriteLine("Geben Sie ein Jahr an:");
year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Geben Sie ein Monat an:");
month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Geben Sie ein Tag an:");
day = Convert.ToInt32(Console.ReadLine());

if ((year % 4) == 0)
{
    isLeapYear = true;
    if ((year % 100) == 0)
    {
        isLeapYear = false;
        if ((year % 400) == 0)
        {
            isLeapYear = true;
        }
    }
}
else
{
    isLeapYear = false;
}

if (day <= 0 || month <= 0 || year <= 0)
{
    Console.WriteLine($"Angegebenes Datum ist nicht gültig: {day}.{month}.{year}\nTag, Monat oder Jahr im Minusbereich oder gleich Null");
}

if (month > 12)
{
    Console.WriteLine($"Angegebenes Datum ist nicht gültig: {day}.{month}.{year}\nDatum ist größer 12");
}

switch (month)
{
    case 1:
        maxDays = 31;
        break;
    case 2:
        maxDays = isLeapYear ? 29 : 28;
        break;
    case 3:
        maxDays = 31;
        break;
    case 4:
        maxDays = 30;
        break;
    case 5:
        maxDays = 31;
        break;
    case 6:
        maxDays = 30;
        break;
    case 7:
        maxDays = 31;
        break;
    case 8:
        maxDays = 31;
        break;
    case 9:
        maxDays = 30;
        break;
    case 10:
        maxDays = 31;
        break;
    case 11:
        maxDays = 30;
        break;
    case 12:
        maxDays = 31;
        break;
}

Console.WriteLine(maxDays);

if (day > maxDays)
{
    Console.WriteLine($"Angegebenes Datum ist nicht gültig: {day}.{month}.{year}\nDer Monat {month} hat nur {maxDays} Tage.");
}

if (year > 2100)
{
    Console.WriteLine($"Angegebenes Datum ist nicht gültig: {day}.{month}.{year}\nDas Jahr darf nicht größer als 2100 sein.");
}

