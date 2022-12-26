// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

Console.WriteLine("Введите индекс элемента массива по горизонтали: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс элемента массива по вертикали: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[4, 4];
for (int i = 0; i < matr.GetLength(0); i++)
{
    Random rnd = new Random();
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = Convert.ToInt32(rnd.Next(-10, 10));
        Console.Write(String.Format("{0,3}", matr[i, j]));
    }
    Console.WriteLine();
}
Console.WriteLine();
if (a > 3 || b > 3 || a < 0 || b < 0)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else if (a <= 3 || b <= 3)
{
    Console.WriteLine($"Искомый элемент = {matr[a, b]}");
}
