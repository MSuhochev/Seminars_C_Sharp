// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру 
// этого числа.
// 456 -> 46, 782 -> 72, 918 -> 98

int num = new Random().Next(100, 1000);
int digit2 = num % 10;
int digit1 = num / 100;
Console.WriteLine($"Случайное число = {num}, Первая цифра = {digit1}, Третья цифра = {digit2}");
int summ = digit1 * 10 + digit2;
Console.WriteLine(summ);
