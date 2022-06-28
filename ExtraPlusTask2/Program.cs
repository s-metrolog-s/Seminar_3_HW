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

Console.WriteLine($"Координаты точки A: [{arrayA[0]} ; {arrayA[1]}]"); // x1    y1
Console.WriteLine($"Координаты точки B: [{arrayB[0]} ; {arrayB[1]}]"); // x2    y2
Console.WriteLine($"Координаты точки C: [{arrayC[0]} ; {arrayC[1]}]"); // x3    y3
Console.WriteLine($"Координаты точки D: [{arrayD[0]} ; {arrayD[1]}]"); // x4    y4
Console.WriteLine("*******************************************");

Console.WriteLine($"Вектора AB и CD {CrossingVectors(arrayA, arrayB, arrayC, arrayD)}");
Console.WriteLine("*******************************************");

void PutPoint(int[] currentArray)
{
    currentArray[0] = rand.Next(-10, 10); 
    currentArray[1] = rand.Next(-10, 10);
}

int vectorMult(int ax,int ay,int bx,int by) //векторное произведение
{
    return ax * by - bx * ay;
}                     

string CrossingVectors (int[] array1, int[] array2, int[] array3, int[] array4) //проверка пересечения векторов
{                                                       
    int v1 = vectorMult(arrayD[0] - arrayC[0], arrayD[1] - arrayC[1], arrayA[0] - arrayC[0], arrayA[1] - arrayC[1]);
    int v2 = vectorMult(arrayD[0] - arrayC[0], arrayD[1] - arrayC[1], arrayB[0] - arrayC[0], arrayB[1] - arrayC[1]);
    int v3 = vectorMult(arrayB[0] - arrayA[0], arrayB[1] - arrayA[1], arrayC[0] - arrayA[0], arrayC[1] - arrayA[1]);
    int v4 = vectorMult(arrayB[0] - arrayA[0], arrayB[1] - arrayA[1], arrayD[0] - arrayA[0], arrayD[1] - arrayA[1]);
    if ((v1 * v2) < 0 && (v3 * v4) < 0)
    return "пересекаются";
    else return "не пересекаются";
}