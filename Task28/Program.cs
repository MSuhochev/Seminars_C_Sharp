// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение 
// чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());

}
int GetSumToNumber(int number)  //возвращает сумму от 1 до намбер
{
    int multi = 1;
    for(int i = 1; i <= number; i++)
    {
        multi *= i;
    }
    return multi;

}
int A = ReadInt("Введите число: ");
int result = GetSumToNumber(A);
Console.WriteLine($"Произведение чисел от 1 до {A} = {result}");


