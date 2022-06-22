// Задача 1. На ввод подаётся номер четверти. 
// Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для 
// торгового менеджера, который выезжает из центра координат.


Random rand = new Random();
Console.WriteLine("Определение оптимального маршрута менеджера");
Console.WriteLine("*******************************************");
int quarter = rand.Next(1, 5);
Console.WriteLine($"Выбрана {quarter} четверть");

int[] arrayA  = new int[2];
int[] arrayB  = new int[2];
int[] arrayC = new int[2];

int maxX = 0;
int maxY = 0;

int maxArea = 100; //rand.Next(10, 1000);

if (quarter == 1) maxX = maxArea; maxY = maxArea;
if (quarter == 2) maxX = -maxArea; maxY = maxArea;
if (quarter == 3) maxX = -maxArea; maxY = -maxArea;
if (quarter == 4) maxX = maxArea; maxY = -maxArea;

PutPoint(arrayA, maxX, maxY);
PutPoint(arrayB, maxX, maxY);
PutPoint(arrayB, maxX, maxY);

void PutPoint(int[] currentArray, int X, int Y)
{
    currentArray[0] = rand.Next(0, X); 
    currentArray[1] = rand.Next(0, Y); 
}

Console.WriteLine($"{arrayA[0]};{arrayA[1]}");
Console.WriteLine($"{arrayB[0]};{arrayB[1]}");
Console.WriteLine($"{arrayC[0]};{arrayC[1]}");
