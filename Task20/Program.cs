// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt(a*b);
// Math.Pow(a, b);
// Console.WriteLine($"{resSqrt:f5}");

Console.WriteLine("Введите координаты Х1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Х2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
int x3 = x1 - x2;
int y3 = y1 - y2;
double respow = Math.Pow(x3,2);
double respow2 = Math.Pow(y3,2);
double sumpow = respow + respow2;
double result = Math.Sqrt(sumpow);
Console.WriteLine($"{result:f2}"); // {Math.Sqrt((xb-xa)(xb-xa) + (yb-ya)(yb-ya))}");
