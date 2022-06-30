// Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие цифру 3. 
// Вывести в консоль новый массив и количество удалённых элементов.

Random rand = new Random();
int[] array = new int[100];

FillArray(array);
PrintArray(array);

void FillArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 100);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if ((i + 1) % 20 == 1) Console.WriteLine();
        Console.Write($"{currentArray[i]}\t");
    }
}