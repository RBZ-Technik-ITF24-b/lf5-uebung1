// Aufabe 11 Sorting Arrays

int[] array = new int[5];
int[] sorted = new int[5];
string dir;
bool check;

Console.WriteLine("Geben Sie 5 Zahlen ein und bestätigen Sie jede einzelne Zahl mit Enter");
array[0] = Convert.ToInt16(Console.ReadLine());
array[1] = Convert.ToInt16(Console.ReadLine());
array[2] = Convert.ToInt16(Console.ReadLine());
array[3] = Convert.ToInt16(Console.ReadLine());
array[4] = Convert.ToInt16(Console.ReadLine());

do
{
    Console.WriteLine("Möchten Sie die Zahlen Aufsteigend oder Absteigend sortieren?");
    dir = Console.ReadLine();

    switch (dir)
    {
        case "Aufsteigend":
            sorted = array.OrderBy(c => c).ToArray();
            check = true;
            break;
        case "Absteigend":
            sorted = array.OrderByDescending(c => c).ToArray();
            check = true;
            break;
        default:
            Console.WriteLine("Falsche eingabe!!");
            check = false;
            break;
    }
} while (!check);

Console.WriteLine($"Original: [{string.Join(", ", array)}]");
Console.WriteLine($"{dir} sortiert: [{string.Join(", ", sorted)}]");
