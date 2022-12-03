// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if(num > 99 && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
else if(num > 999 && num < 10000)
{
    num = num % 100;
    num = num / 10;
    Console.WriteLine(num);
}
else if(num > 10000 && num < 100000)
{
    num = num % 1000;
    num = num / 100;
    Console.WriteLine(num);
}
else if(num > 100000 && num < 1000000)
{
    num = num % 10000;
    num = num / 1000;
    Console.WriteLine(num);
}