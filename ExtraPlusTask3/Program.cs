// Задача 3. Найти в какой четверти лежит 
// точка пересечения из задачи 2 (если вектора пересекаются).

Console.Clear();
Random rand = new Random();
Console.WriteLine("*******************************************");
Console.WriteLine("Даны 4 случайные точки на плоскости");
Console.WriteLine("*******************************************");

int[] arrayA = new int[2];    // {-3, 3}; //{-7, -1}; Для данных точек пересечение проверено
int[] arrayB = new int[2];    // {3, -3};   //{8, 7};
int[] arrayC = new int[2];    // {-3, -3};  //{3, -5};
int[] arrayD = new int[2];   // {3, 3};  //{-1, 3};

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

bool flag = CrossingVectors(arrayA, arrayB, arrayC, arrayD);
Console.Write($"Вектора AB и CD ");
if (flag)
{
    Console.Write($"пересекаются ");
    PointCrossing(arrayA, arrayB, arrayC, arrayD);
}
else
{
    Console.WriteLine("не пересекаются");
}
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

bool CrossingVectors (int[] array1, int[] array2, int[] array3, int[] array4) //проверка пересечения векторов
{                                                       
    int v1 = vectorMult(array4[0] - array3[0], array4[1] - array3[1], array1[0] - array3[0], array1[1] - array3[1]);
    int v2 = vectorMult(array4[0] - array3[0], array4[1] - array3[1], array2[0] - array3[0], array2[1] - array3[1]);
    int v3 = vectorMult(array2[0] - array1[0], array2[1] - array1[1], array3[0] - array1[0], array3[1] - array1[1]);
    int v4 = vectorMult(array2[0] - array1[0], array2[1] - array1[1], array4[0] - array1[0], array4[1] - array1[1]);
    if ((v1 * v2) < 0 && (v3 * v4) < 0)
    return true;
    else return false;
}

void PointCrossing(int[] array1, int[] array2, int[] array3, int[] array4)
{
    double A1 = array2[1] - array1[1];
    double A2 = array4[1] - array3[1];
    double B1 = array1[0] - array2[0];
    double B2 = array3[0] - array4[0];
    double C1 = -array1[0] * array2[1] + array1[1] * array2[0];
    double C2 = -array3[0] * array4[1] + array3[1] * array4[0];

    double D = (A1 * B2) - (A2 * B1);
    double Dx = (B1 * C2) - (B2 * C1);
    double Dy = (A2 * C1) - (A1 * C2);

    if (D != 0)
    {
        double X = Dx / D;
        double Y = Dy / D;
        Console.WriteLine($"в точке [{Math.Round(X, 2)} : {Math.Round(Y, 2)}]");
        if (X > 0 && Y > 0) Console.WriteLine("Точка располагается в 1 четверти");
        if (X < 0 && Y > 0) Console.WriteLine("Точка располагается в 2 четверти");
        if (X < 0 && Y < 0) Console.WriteLine("Точка располагается в 3 четверти");
        if (X > 0 && Y < 0) Console.WriteLine("Точка располагается в 4 четверти");
    }
}

