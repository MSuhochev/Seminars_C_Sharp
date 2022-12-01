//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("max = ");
    Console.Write(a);
    Console.Write(" min = ");
    Console.Write(b);
}
else if(b > a)
{
   Console.Write("max = ");
   Console.Write(b);
   Console.Write(" min = ");
   Console.Write(a);
}
else if(a == b)
{
    Console.Write("Числа равны");
}


