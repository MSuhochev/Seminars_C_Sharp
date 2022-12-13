/*Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵); 2, 4 -> 16 */

Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В - (оно будет являться степенью \nв которую необходимо возвести число А):");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;
int count = 1;
while(count < b)
{
    res = a * res;
    count++; 
}
Console.WriteLine($"Число {a} в {b} степени = {res}");