// Задача 1. Рассчитать значение y при заданном x по формуле
// y = sin(2 степени)x, при x > 0
// y = 1 - 2sinx(2 степени) в противном случае

Random rand = new Random();
int x = rand.Next(1, 10);
Console.Clear();
Console.WriteLine("*******************************************");
double y;

Console.WriteLine($"Дано значение x равное: {x}");

if (x > 0)
{
y = Math.Round(Math.Pow(Math.Sin(x), 2), 2);
}
else
{
y = Math.Round(1 - 2 * Math.Sin(Math.Pow(x, 2)), 2);
}

Console.WriteLine(y);
Console.WriteLine("*******************************************");