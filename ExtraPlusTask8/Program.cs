// Задача 8. Напишите программу, который выводит на консоль 
// таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.

Console.Clear();
Random rand = new Random();
int number = rand.Next(2, 100);
int count = 1;

for (int i = 1; i <= number; i++)
{
    count = 1;
    for (int j = 1; j <= 10; j++)
    {
    Console.WriteLine($"{i} * {count} -> {i * count}");
    count++;
    }
    Console.WriteLine();
}