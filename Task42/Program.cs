/*Задача 42: Напишите программу, которая будет 
преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите десятичное число для преобразования этого числа в двоичное:");
int num = Convert.ToInt32(Console.ReadLine());
PrintBinaryView(num);
void PrintBinaryView(int n)
{
    if(n <= 0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}
