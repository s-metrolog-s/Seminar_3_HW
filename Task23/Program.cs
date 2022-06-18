// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Random rand = new Random();
int N = rand.Next(1, 10);
int count = 1;
double cube = 1;

Console.WriteLine($"Таблица кубов чисел от 1 до {N}");
Console.WriteLine("--------");
while (count <= N)
{
    cube = Math.Pow(count, 3);
    Console.WriteLine($"{count} | {cube}");
    count++;
}
Console.WriteLine("--------");