// Aufgabe 8 Heronverfahren

Console.WriteLine("Geben Sie eine Zahl ein");
double input = Convert.ToDouble(Console.ReadLine());
double sqrt = (input + 1) / 2, prev;

Console.WriteLine($"{input}   {sqrt}");
do
{
    prev = sqrt;
    sqrt = 0.5 * (sqrt + (input / sqrt));
    Console.WriteLine(sqrt);
}
while (Math.Abs(sqrt - prev) > 0.0001);

Console.WriteLine(sqrt);