﻿// Задача 3. Дано трёх значное число N. 
// Определить, есть ли среди его цифр 4 или 7.

Random rand = new Random();

void MakeArray(int[] currentArray, int number)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[currentArray.Length - 1 - i] = number % 10;
        number = number / 10;
    }
}

void FindValue(int[] currentArray, int value1, int value2)
{
    bool flag1 = false;
    bool flag2 = false;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] == value1) flag1 = true;
        if (currentArray[i] == value2) flag2 = true;
    }
    
    if (flag1 == true && flag2 == true) Console.WriteLine($"Число содержит {value1} и {value2}");
    else if (flag1) Console.WriteLine($"Число содержит {value1}");
    else if (flag2) Console.WriteLine($"Число содержит {value2}");
    else Console.WriteLine($"Число не содержит чисел {value1} и {value2}");
}

int[] array = new int[3];
int N1 = rand.Next(100, 999);
int N2 = 547;
int N3 = 127;
int N4 = 345;

Console.WriteLine($"Даны трехзначные числа: {N1} {N2} {N3}");
Console.WriteLine("Начинаем поиск чисел 4 и 7...");

MakeArray(array, N1);
FindValue(array, 4, 7);

MakeArray(array, N2);
FindValue(array, 4, 7);

MakeArray(array, N3);
FindValue(array, 4, 7);

MakeArray(array, N4);
FindValue(array, 4, 7);
