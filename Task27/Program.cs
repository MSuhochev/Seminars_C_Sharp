/*Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;  82 -> 10; 9012 -> 12      */

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sumnum = 0;
int tmpnum = num;
while(tmpnum > 0)
{
    sumnum += tmpnum % 10;
    tmpnum /= 10;
}
Console.WriteLine($"Сумма цифр числа {num} равна {sumnum}");