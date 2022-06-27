// Задача 2. Даны 4 точки a, b, c, d. 
// Пересекаются ли вектора AB и CD?

Console.Clear();
Random rand = new Random();
Console.WriteLine("*******************************************");
Console.WriteLine("Даны 4 случайные точки на плоскости");
Console.WriteLine("*******************************************");

int[] arrayA = new int[2];
int[] arrayB = new int[2];
int[] arrayC = new int[2];
int[] arrayD = new int[2];

// Устанавливаем точки в пространстве
PutPoint(arrayA);
PutPoint(arrayB);
PutPoint(arrayC);
PutPoint(arrayD);

Console.WriteLine($"Координаты точки A: [{arrayA[0]} ; {arrayA[1]}]");
Console.WriteLine($"Координаты точки B: [{arrayB[0]} ; {arrayB[1]}]");
Console.WriteLine($"Координаты точки C: [{arrayC[0]} ; {arrayC[1]}]");
Console.WriteLine($"Координаты точки D: [{arrayD[0]} ; {arrayD[1]}]");

void PutPoint(int[] currentArray)
{
    currentArray[0] = rand.Next(-100, 100); 
    currentArray[1] = rand.Next(-100, 100);
}