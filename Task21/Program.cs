// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("*******************************************");

Random rand = new Random();
int x1 = rand.Next(1, 10);
int y1 = rand.Next(10, 50);
int z1 = rand.Next(50, 100);
int x2 = rand.Next(1, 10);
int y2 = rand.Next(10, 50);
int z2 = rand.Next(50, 100);
/*
int x1 = 7;
int y1 = -5;
int z1 = 0;
int x2 = 1;
int y2 = -1;
int z2 = 9;
*/
Console.WriteLine($"Координаты точки A[{x1};{y1};{z1}]");
Console.WriteLine($"Координаты точки B[{x2};{y2};{z2}]");
Console.Write("Расстояние между точками A и B равно: ");
double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(Math.Round(result, 2));
Console.WriteLine("*******************************************");
