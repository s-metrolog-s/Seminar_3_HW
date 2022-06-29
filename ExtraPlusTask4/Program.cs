// Задача 4. Дан массив средних температур (массив заполняется случайно) 
// за последние 10 лет. На ввод подают номер месяца и год начала и конца.
// Определить самые высокие и низкие температуры для 
// лета, осени, зимы и весны в заданном промежутке. 
// Если таких температур нет, сообщить, что определить не удалось.

Random rand = new Random();
int[] array = new int[120];

Console.WriteLine("Дан массив средних температур с 2011 по 2020 года");
Console.WriteLine("*****************************************************************************************************");
FillArray(array);
PrintArray(array);
Console.WriteLine("*****************************************************************************************************");

int startYear = InputYear("начальный");
int endYear = InputYear("конечный");
int startMonth = InputMonth("начальный");
int endMonth = InputMonth("конечный");

FindTemp(array, startYear, endYear, startMonth, endMonth);

void FillArray(int[] currentArray)
{
    int j = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (i >= 12) j = (i + 1) % 12;
        else j = i + 1;
        // Заполняем массив средними температурами
        if (j == 0 || j == 12 || j == 1 || j == 2) currentArray[i] = rand.Next(-30, -11);
        if (j == 3 || j == 4 || j == 5) currentArray[i] = rand.Next(1, 16);
        if (j == 6 || j == 7 || j == 8) currentArray[i] = rand.Next(15, 31);
        if (j == 9 || j == 10 || j == 11) currentArray[i] = rand.Next(1, 15);
    }
}

void PrintArray(int[] currentArray)
{
    int j = 2010;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if ((i + 1) % 12 == 1)
        { 
        Console.WriteLine();
        Console.Write(j + 1 + ": ");
        j++;
        }
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

int InputYear(string name)
{
    Console.WriteLine($"Введите {name} год:");

    int input;
    while (true)
    {
        input = Convert.ToInt32(Console.ReadLine());
        if (input > 2010 && input < 2021) break;
        else
        {
        Console.WriteLine("Введите число в пределах от 2010 до 2020 годов");
        }
    }
    return input;
}

int InputMonth(string name)
{
    Console.WriteLine($"Введите {name} месяц:");

    int input;
    while (true)
    {
        input = Convert.ToInt32(Console.ReadLine());
        if (input <= 12 && input > 0) break;
        else
        {
        Console.WriteLine("Введите месяц с пределах 1 .. 12");
        }
    }
    return input;
}

void FindTemp(int [] currentArray, int startY, int endY, int startM, int endM)
{
    int maxTemp = 0;
    int minTemp = 0;
    for (int i = ((startY) + (startM - 1)) % 2011; i < ((endY) + (endY % 2011 * 12) + (endM - 1)) % 2011; i++)
    {
        if (currentArray[i] > maxTemp) maxTemp = currentArray[i];
        if (currentArray[i] < minTemp) minTemp = currentArray[i];
    }
    Console.WriteLine(maxTemp + " : " + minTemp);
}