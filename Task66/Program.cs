// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumLine(int min, int max)
{
    int sum = 0;
    if (max == min) return min;
    if (max > min)
    sum += max + SumLine( min, max -1);
    return sum;
}

int min = ReadInt("Введите первое число:");
Console.WriteLine();
int max = ReadInt("Введите второе число:");
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {min} до {max} = {SumLine(min, max)}");
Console.WriteLine();