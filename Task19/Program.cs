// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int tmpnum = num1;
int num2 = 0;
int tmp = 0;
if(num1 < 9999 || num1 > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите ввод");
    return;
}
while(tmpnum > 0)
{
    tmp = tmpnum % 10;
    tmpnum = tmpnum / 10;
    num2 = num2 * 10;
    num2 = num2 + tmp;
}
if(num1 == num2)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}