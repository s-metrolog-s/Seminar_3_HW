// Задача 4. Дан массив длиной 10 элементов. 
// Заполнить его числами от 1 до 10.

Random rand = new Random();
int[] array = new int[10];

Console.Clear();
Console.WriteLine("Заполним массив числами от 1 до 10");
Console.WriteLine("**************************************************************************");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 11);
    Console.Write($"{array[i]} \t");
}
Console.WriteLine();
Console.WriteLine("**************************************************************************");