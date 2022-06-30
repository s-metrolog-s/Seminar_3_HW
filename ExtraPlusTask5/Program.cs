// Задача 5. На вход подаётся число n > 4, указывающее длину пароля. 
// Создайте метод, генерирующий пароль заданной длины. 
// В пароле обязательно использовать цифру, букву и специальный знак.

Random rand = new Random();
int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] specials = new string[] {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")"};
string letters = "abcdefghijklmnopqrstuvwxyz";
string[] lettersArray = new string[23];

Console.Clear();
Console.WriteLine("**********************************");
Console.WriteLine("*********Генератор пароля*********");
Console.WriteLine("**********************************");
Console.WriteLine("Введите длину пароля:");
int number = Convert.ToInt32(Console.ReadLine());
int numberChecked = CheckLength(number);
Console.WriteLine("**********************************");
Console.WriteLine("Генерируем пароль...");
Console.WriteLine("Новый пароль: ");
PassGenerate(numberChecked, numbers, specials, letters);
Console.WriteLine();
Console.WriteLine("**********************************");

void PassGenerate(int number, int[] numbers, string[] specials, string letters)
{
    bool let = false; // Проверка на наличие в пароле букв
    bool num = false; // Проверка на наличие в пароле цифр
    bool spec = false; // Проверка на наличие в пароле специальных символов
    for (int i = 0; i < number - 1; i++)
    {
        int switchRandom = rand.Next(0, 3);
        switch (switchRandom)
        {
            case 0:
                Console.Write(numbers[rand.Next(0, 10)]);
                num = true;
                break;
            case 1:
                Console.Write(specials[rand.Next(0, 10)]);
                spec = true;
                break;
            case 2:
                Console.Write(letters[rand.Next(0, 24)]);
                let = true;
                break;
        }
    }
    if (let && num && spec) Console.Write(letters[rand.Next(0, 24)]);
    else if (!num) Console.Write(numbers[rand.Next(0, 10)]);
    else if (!spec) Console.Write(specials[rand.Next(0, 10)]);
    else Console.Write(letters[rand.Next(0, 24)]);
}

int CheckLength(int number) //Метод для проверки правильности ввода
{
    if (number > 4) 
    {
        Console.WriteLine("\t Пароль принят");
        return number;
    }
    else 
    {
        Console.WriteLine("Небезопасный пароль, введите снова:");
        return CheckLength(number = Convert.ToInt32(Console.ReadLine()));
    }
}