/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double Double()
{
    var num = Convert.ToDouble(Console.ReadLine());
    return num;
}
Console.WriteLine("Введите координаты b1:");
double b1 = Double();
Console.WriteLine("Введите координаты k1:");
double k1 = Double();
Console.WriteLine("Введите координаты b2:");
double b2 = Double();
Console.WriteLine("Введите координаты k2:");
double k2 = Double();
double x = Math.Round((b2-b1) / (k1-k2), 2);
double y = Math.Round(k2 * ((b2-b1) / (k1-k2)) + b2, 2);
Console.WriteLine($"Координаты точки пересечения x = {x} y = {y}");

