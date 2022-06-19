// Задача 2. Дано трёх значное число N. 
// Определить кратна ли трём сумма всех его цифр.

Random rand = new Random();
int N = rand.Next(1, 10);
Console.WriteLine($"Дано число N равное: {N}");

int sum;

int[] MakeArray(int number)
{
    int[] arrayValue = new int[];
    int del = 100;
    for (int i = 0; i < Convert.ToString.number.Length; i++)
    {
        arrayValue[i] = number / del;
        del = del / 10;
    }
}

