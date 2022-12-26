// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. Используя рекурсию.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


int nummin = 5;
int nummax = 10;

int Line(int m, int n)
{
    if(n < 0) return -1;
    if(n == m) return m;
    Console.Write(Line(m, n - 1));
    return n;
}
Console.Write(Line(nummin, nummax));