// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m < 0 || n < 0) return 0;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return n;
}

int min = ReadInt("Введите первое число:");
int max = ReadInt("Введите второе число:");
Console.WriteLine();
Console.WriteLine($"Результат функции Аккермана для чисел {min} и {max} = {Akkerman(min, max)}");
Console.WriteLine();
