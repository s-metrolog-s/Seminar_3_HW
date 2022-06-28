// Задача 4. Дан массив средних температур (массив заполняется случайно) 
// за последние 10 лет. На ввод подают номер месяца и год начала и конца.
// Определить самые высокие и низкие температуры для 
// лета, осени, зимы и весны в заданном промежутке. 
// Если таких температур нет, сообщить, что определить не удалось.

Random rand = new Random();
int[] array = new int[120];

FillArray(array);
PrintArray(array);

void FillArray(int[] currentArray)
{
    int j = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (i > 11) 
        {
            j = (i + 1) % 12;
        }
        else
        {
            j = i + 1;
        }
        // Заполняем массив средними температурами
        if (j == 12 || j == 1 || j == 2) currentArray[i] = rand.Next(-30, -11);
        if (j == 3 || j == 4 || j == 5) currentArray[i] = rand.Next(0, 16);
        if (j == 6 || j == 7 || j == 8) currentArray[i] = rand.Next(15, 31);
        if (j == 9 || j == 10 || j == 11) currentArray[i] = rand.Next(0, 15);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if ((i + 1) % 12 == 1) Console.WriteLine();
        Console.Write(currentArray[i] + "\t");
    }
}

