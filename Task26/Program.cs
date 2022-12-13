// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}
int GetCountToNumber(int number)
{
    int count = 0;
    while(number != 0)
    {
        number /= 10; //number = number / 10;
        count++;
    }
    return count;

}
int number = ReadInt("Введите число: ");
int result = GetCountToNumber(number);
Console.WriteLine($"Количество цифр {number} = {result}");
