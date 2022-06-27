// Задача 1. На ввод подаётся номер четверти. 
// Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для 
// торгового менеджера, который выезжает из центра координат.

Console.Clear();
Random rand = new Random();
Console.WriteLine("*******************************************");
Console.WriteLine("Определение оптимального маршрута менеджера");
Console.WriteLine("*******************************************");
int quarter = rand.Next(1, 5);
Console.WriteLine($"Выбрана {quarter} четверть");

int[] arrayA = new int[2];
int[] arrayB = new int[2];
int[] arrayC = new int[2];
int[] zeroArray = new int[2] {0, 0};

PutPoint(arrayA, quarter); //Устанавливаем точки в выбранной четверти
PutPoint(arrayB, quarter);
PutPoint(arrayC, quarter);

Console.WriteLine($"Координаты точки A: [{arrayA[0]} ; {arrayA[1]}]");
Console.WriteLine($"Координаты точки B: [{arrayB[0]} ; {arrayB[1]}]");
Console.WriteLine($"Координаты точки C: [{arrayC[0]} ; {arrayC[1]}]");

// Измерение расстояний между точками
double lengthAB = MeasureLength(arrayA, arrayB);
double lengthBC = MeasureLength(arrayB, arrayC);
double lengthAC = MeasureLength(arrayA, arrayC);
// Измерение расстояний от центра координат
double lengthZeroA = MeasureLength(arrayA, zeroArray);
double lengthZeroB = MeasureLength(arrayB, zeroArray);
double lengthZeroC = MeasureLength(arrayC, zeroArray);

Console.WriteLine("Расстояние AB: " + lengthAB + "\t BC: " + lengthBC + "\t AC: " + lengthAC);
Console.WriteLine("Расстояние ZA: " + lengthZeroA + "\t ZB: " + lengthZeroB + "\t ZC: " + lengthZeroC);
Console.WriteLine("*******************************************");
Console.WriteLine("Прокладываем оптимальный маршрут...");

double minDistance = lengthZeroA;
string flag = "A";

if (lengthZeroB < minDistance)
{
    minDistance = lengthZeroB;
    flag = "B";
}
if (lengthZeroC < minDistance) 
{
    minDistance = lengthZeroC;
    flag = "C";
}

Console.WriteLine($"1. Двигемся к точке {flag} - {minDistance} метра/ов");
/*
void FindBestWay(int firstDist, int secondDist, int thirdDist)
{
    if (firstDist < secondDist)
    {
        Console.WriteLine($"2. Двигемся к точке B - {firstDist} метра/ов");
        Console.WriteLine($"3. Двигемся к точке C - {thirdDist} метра/ов");
    }
    else
    {
        Console.WriteLine($"2. Двигемся к точке C - {secondDist} метра/ов");
        Console.WriteLine($"3. Двигемся к точке B - {thirdDist} метра/ов");
    }
}
*/
if (flag == "A")
{
    if (lengthAB < lengthAC)
    {
        Console.WriteLine($"2. Двигемся к точке B - {lengthAB} метра/ов");
        Console.WriteLine($"3. Двигемся к точке C - {lengthBC} метра/ов");
    }
    else
    {
        Console.WriteLine($"2. Двигемся к точке C - {lengthAC} метра/ов");
        Console.WriteLine($"3. Двигемся к точке B - {lengthBC} метра/ов");
    }
}

if (flag == "B")
{
    if (lengthAB < lengthBC)
    {
        Console.WriteLine($"2. Двигемся к точке A - {lengthAB} метра/ов");
        Console.WriteLine($"3. Двигемся к точке C - {lengthAC} метра/ов");
    }
    else
    {
        Console.WriteLine($"2. Двигемся к точке C - {lengthBC} метра/ов");
        Console.WriteLine($"3. Двигемся к точке A - {lengthAC} метра/ов");
    }
}

if (flag == "C")
{
    if (lengthBC < lengthAC)
    {
        Console.WriteLine($"2. Двигемся к точке B - {lengthBC} метра/ов");
        Console.WriteLine($"3. Двигемся к точке A - {lengthAB} метра/ов");
    }
    else
    {
        Console.WriteLine($"2. Двигемся к точке A - {lengthAC} метра/ов");
        Console.WriteLine($"3. Двигемся к точке B - {lengthAB} метра/ов");
    }
}

void PutPoint(int[] currentArray, int quarter)
{
    switch (quarter)
    {
    case 1:
        currentArray[0] = rand.Next(0, 100); 
        currentArray[1] = rand.Next(0, 100);
        break;
    case 2: 
        currentArray[0] = rand.Next(-100, 1); 
        currentArray[1] = rand.Next(0, 100); 
        break;
    case 3:
        currentArray[0] = rand.Next(-100, 1); 
        currentArray[1] = rand.Next(-100, 1);
        break;
    case 4:
        currentArray[0] = rand.Next(0, 100); 
        currentArray[1] = rand.Next(-100, 1);
        break;
    default:
        Console.WriteLine("Введена не верная четверть");
        break;
    }
}

double MeasureLength(int[] currentArray1, int[] currentArray2)
{
    double length = 0;
    length = Math.Sqrt((Math.Pow((currentArray1[0] - currentArray2[0]), 2) + 
                        Math.Pow((currentArray1[1] - currentArray2[1]), 2)));
    return Math.Round(length, 2);
}

Console.WriteLine("*******************************************");

