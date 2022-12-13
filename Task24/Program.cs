// See https://aka.ms/new-console-template for more information

//считывает целое число от пользователя
int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());

}
int GetSumToNumber(int number)  //возвращает сумму от 1 до намбер
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;

}
int A = ReadInt("Введите число: ");
int result = GetSumToNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");

