// Задача 9. Дана игра со следующими правилами. 
// Первый игрок называет любое натуральное число от 2 до 9, 
// второй умножает его на любое натуральное число от 2 до 9, 
// первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
// Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.

Console.Clear();
Console.WriteLine("******************************************");
Console.WriteLine("Добро пожаловать в игру - Умножь до 1 000");
Console.WriteLine("******************************************");
int stopNumber = 1000;
int result = 1;
int player = 1;
int count = 0;

for (count = 0; result <= stopNumber; count++)
{
    switch (player)
    {
        case 1:
            Console.WriteLine("Число задает игрок № 1");
            result = result * CheckInput(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Результат равен {result}");
            player = 2;
        break;

        case 2:
            Console.WriteLine("Число задает игрок № 2");
            result = result * CheckInput(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Результат равен {result}");
            player = 1;
        break;
    }
}
if (player == 1) player = 2;
if (player == 2) player = 1;

Console.WriteLine("Игра окончена");
Console.WriteLine("******************************************");
Console.WriteLine("Статистика игры:");
Console.WriteLine($"Победу одержал игрок {player}");
Console.WriteLine($"Было использовано {count} иттераций");
Console.WriteLine("******************************************");

int CheckInput(int number) //Метод для проверки правильности ввода
{
    if (number > 1 && number < 10) 
    {
        return number;
    }
    else 
    {
        Console.WriteLine("Введите число от 2 до 9:");
        return CheckInput(number = Convert.ToInt32(Console.ReadLine()));
    }
}

