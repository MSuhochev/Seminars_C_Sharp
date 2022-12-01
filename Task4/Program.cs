//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b & a > c)
{
    Console.Write("max = ");
    Console.Write(a);
}
else if(b > c & b > a)
{
    Console.Write("max = ");
    Console.Write(b); 
}
else if(c > b & c > a)
{
        Console.Write("max = ");
        Console.Write(c);
}
else if(a == b & b == c & c == a)
{
    Console.Write("Все числа равны.");
}