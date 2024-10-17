// Aufgabe 10 EAN

string input;
int sum = 0, remainder, check;

Console.WriteLine("Geben Sie eine EAN ein die Sie prüfen wollen");
input = Console.ReadLine();

for (int i = 0; i < (input.Length - 1); i++)
{
    sum += (((i+1) % 2) == 0) ? (int)char.GetNumericValue(input[i]) * 3 : (int)char.GetNumericValue(input[i]);
}

remainder = sum % 10;

check = (remainder != 0) ? 10 - remainder : 0;

if (check != (int)char.GetNumericValue(input.Last()))
{
    Console.WriteLine($"Die errechnet Prüfsumme beträgt {check}. Die Letzte Zahl Ihres EAN ist {input.Last()}. Der EAN ist NICHT Korrekt.");
} else
{
    Console.WriteLine($"Die errechnet Prüfsumme beträgt {check}. Die Letzte Zahl Ihres EAN ist {input.Last()}. Der EAN ist Korrekt.");
}