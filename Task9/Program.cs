// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
// Например: 78 -> 8, 12-> 2, 85 -> 8

int num = new Random().Next(10, 100);
int digit2 = num % 10;
int digit1 = num / 10;
//Console.WriteLine("Случайное число = " + num + "Первая цифра = " + digit1 +)
Console.WriteLine($"Случайное число = {num}, Первая цифра = {digit1}, Вторая цифра = {digit2}");
int max = digit1;
if(max<digit2)
{
    max = digit2;
}
Console.WriteLine(max);