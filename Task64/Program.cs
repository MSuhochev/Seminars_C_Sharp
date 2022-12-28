// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int LineRevers(int min, int max)
{
    if (max == min) return min;
    if (max < min) 
    Console.Write(LineRevers(min - 1, max) + ", ");
    else 
    Console.Write(LineRevers(min + 1, max) + ", ");
    return min;
}

int min = 1;
int max = ReadInt("Введите число:");
Console.WriteLine();
Console.WriteLine(LineRevers(min, max));
Console.WriteLine();
