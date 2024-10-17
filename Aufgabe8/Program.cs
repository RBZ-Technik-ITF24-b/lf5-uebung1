// Aufgabe 8 Heronverfahren

Console.WriteLine("Geben Sie eine Zahl ein");
double input = Convert.ToDouble(Console.ReadLine());
double sqrt = input;
do
{
    sqrt = (1 / 2) * (sqrt + (input / sqrt));
}
while (true);

Console.WriteLine(sqrt);