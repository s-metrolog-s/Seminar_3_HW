// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("*******************************************");
Console.Write("Даны пятизначные числа: ");

int N1 = 14212;
int N2 = 23432;
int N3 = 12821;

Console.WriteLine($"{N1} {N2} {N3}");

void checkPol (int number)
{
   
    if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
    {
        Console.WriteLine($"Число {number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является полиндромом");
    }

}

checkPol(N1);
checkPol(N2);
checkPol(N3);

Console.WriteLine("*******************************************");