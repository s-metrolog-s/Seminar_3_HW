// Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие цифру 3. 
// Вывести в консоль новый массив и количество удалённых элементов.

Random rand = new Random();
int[] arrayBefore = new int[100];

Console.Clear();
Console.WriteLine("***************************************************************************");
Console.WriteLine("Заполним массив случайными числами:");
FillArray(arrayBefore);
PrintArray(arrayBefore);

Console.WriteLine("***************************************************************************");
ChangeNumbers(arrayBefore); // Заменим все элементы с 3 на "-1"

int countDel = CountNumbers(arrayBefore); // Подсчет количества элементов с 3
int[] arrayAfter = new int[arrayBefore.Length - countDel];
FillArrayWithoutSymbol(arrayBefore, arrayAfter);
Console.WriteLine($"Удаляем {countDel} элемент (-а, -ов), которые содержать цифру 3");

PrintArray(arrayAfter);
Console.WriteLine("***************************************************************************");

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
        if ((i + 1) % 10 == 1) Console.WriteLine();
        Console.Write($"{currentArray[i]}\t");
    }
    Console.WriteLine();
}

void ChangeNumbers(int []currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] / 10 == 3 || currentArray[i] % 10 == 3)
        {
            currentArray[i] = - 1;
        }
    }
}

int CountNumbers(int []currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] == - 1) count++;
    }
    return count;
}

void FillArrayWithoutSymbol(int[] currentArray1, int[] currentArray2)
{
    int j = 0;
    for (int i = 0; i < currentArray1.Length; i++)
    {
        if (currentArray1[i] != - 1)
        {
        currentArray2[j] = currentArray1[i];
        j = j + 1;
        }
    }
}