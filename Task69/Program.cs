// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A");
int num = Convert.ToInt32(Console.ReadLine()); //math.abs убираем минус(если ввели отрицательное число)
Console.WriteLine("Введите число B");
int num2 = Convert.ToInt32(Console.ReadLine());
int Product(int n, int m)
{
    if (m==0) return 1;
    else
    {
        n *= Product(n, m -1);
    }
    return n;
}

Console.WriteLine(Product(num, num2));