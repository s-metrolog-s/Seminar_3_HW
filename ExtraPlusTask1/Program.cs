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

PutPoint(arrayA, quarter);
PutPoint(arrayB, quarter);
PutPoint(arrayC, quarter);

Console.WriteLine($"Координаты точки A: [{arrayA[0]} ; {arrayA[1]}]");
Console.WriteLine($"Координаты точки B: [{arrayB[0]} ; {arrayB[1]}]");
Console.WriteLine($"Координаты точки C: [{arrayC[0]} ; {arrayC[1]}]");

// Измерение расстояний между точками и от центра координат
double lengthAB = MeasureLength(arrayA, arrayB);
double lengthBC = MeasureLength(arrayB, arrayC);
double lengthAC = MeasureLength(arrayA, arrayC);
double lengthZeroA = MeasureLength(arrayA, zeroArray);
double lengthZeroB = MeasureLength(arrayB, zeroArray);
double lengthZeroC = MeasureLength(arrayC, zeroArray);

Console.WriteLine(lengthAB + " : " + lengthBC + " : " + lengthAC);
Console.WriteLine(lengthZeroA + " : " + lengthZeroB + " : " + lengthZeroC);

double minDistance = lengthZeroA;
string flag1 = "A";
string flag2 = "";
string flag3 = "";

if (lengthZeroB < minDistance)
{
    minDistance = lengthZeroB;
    flag1 = "B";
}
if (lengthZeroC < minDistance) 
{
    minDistance = lengthZeroC;
    flag1 = "C";
}

Console.WriteLine($"1. Двигемся к точке {flag1} - {minDistance} метра/ов");

if (flag1 == "A")
{
    if (lengthAB < lengthAC)
    {
        minDistance = lengthAB;
        flag2 = "B";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "C";
        Console.WriteLine($"3. Двигемся к точке C - {lengthBC} метра/ов");
    }
    else
    {
        minDistance = lengthAC;
        flag2 = "C";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "B";
        Console.WriteLine($"3. Двигемся к точке B - {lengthBC} метра/ов");
    }
}

if (flag1 == "B")
{
    if (lengthAB < lengthBC)
    {
        minDistance = lengthAB;
        flag2 = "A";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "C";
        Console.WriteLine($"3. Двигемся к точке C - {lengthAC} метра/ов");
    }
    else
    {
        minDistance = lengthBC;
        flag2 = "C";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "A";
        Console.WriteLine($"3. Двигемся к точке A - {lengthAC} метра/ов");
    }
}

if (flag1 == "C")
{
    if (lengthBC < lengthAC)
    {
        minDistance = lengthBC;
        flag2 = "B";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "A";
        Console.WriteLine($"3. Двигемся к точке A - {lengthAB} метра/ов");
    }
    else
    {
        minDistance = lengthAC;
        flag2 = "A";
        Console.WriteLine($"2. Двигемся к точке {flag2} - {minDistance} метра/ов");
        flag3 = "B";
        Console.WriteLine($"3. Двигемся к точке B - {lengthAB} метра/ов");
    }
}

void PutPoint(int[] currentArray, int quarter)
{
    if (quarter == 1) 
    {
    currentArray[0] = rand.Next(0, 100); 
    currentArray[1] = rand.Next(0, 100); 
    }
    else if (quarter == 2)
    {
    currentArray[0] = rand.Next(-100, 1); 
    currentArray[1] = rand.Next(0, 100); 
    }
    else if (quarter == 3)
    {
    currentArray[0] = rand.Next(-100, 1); 
    currentArray[1] = rand.Next(-100, 1); 
    }
    else if (quarter == 4)
    {
    currentArray[0] = rand.Next(0, 100); 
    currentArray[1] = rand.Next(-100, 1);
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

