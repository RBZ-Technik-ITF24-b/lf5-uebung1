// Aufgabe 9 größter gemeinsame Teiler

int in1;
int num1;
int in2;
int num2;
int ggt = 0;
string again = "n";

do
{
    Console.WriteLine("Berechnung des größten gemeinsamen Teilers");
    Console.WriteLine("Geben Sie die erste Zahl an:");
    in1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Geben Sie die zweite Zahl an:");
    in2 = Convert.ToInt16(Console.ReadLine());

    num1 = in1;
    num2 = in2;

    while (num1 != num2)
    {
        if (num1 > num2)
        {
            num1 = num1 - num2;
        } else if (num1 < num2)
        {
            num2 = num2 - num1;
        }
    }

    ggt = num1;

    Console.WriteLine($"Die erste eingegebene Zahl ist {in1}");
    Console.WriteLine($"Die zweite eingegebene Zahl ist {in2}");
    Console.WriteLine($"Der größte gemeinsame Teiler ist {ggt}");

    Console.WriteLine("Wollen Sie eine weitere Berechnung durchführen? (J/n)");
    again = Console.ReadLine();
    again = string.IsNullOrEmpty(again) ? again = "j" : again;
} while (again.Equals("j") || again.Equals("J"));