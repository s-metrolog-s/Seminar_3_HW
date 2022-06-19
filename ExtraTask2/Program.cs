// Задача 2. Дано трёх значное число N. 
// Определить кратна ли трём сумма всех его цифр.

Console.Clear();
Random rand = new Random();
int N = rand.Next(100, 1000);
Console.WriteLine("*******************************************");
Console.WriteLine($"Дано число N равное: {N}");

int[] array = new int[3];

MakeArray(array, N);
int sum = array[0] + array[1] + array[2];

Console.WriteLine($"Сумма всех чисел числа равна: {sum}");
if (sum % 3 == 0)
{
    Console.WriteLine($"Сумма {sum} кратна числу 3");
}
else
{
    Console.WriteLine($"Сумма {sum} не кратна числу 3");
}

void MakeArray(int[] currentArray, int value)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        currentArray[i] = value % 10;
        value = value / 10;
    }
}
Console.WriteLine("*******************************************");

