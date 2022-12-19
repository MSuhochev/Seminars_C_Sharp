/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/
void NewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}
void FindArrayNumber(int [] array, int number)
{
    bool find = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        find = true;
    }
    if (find == true)
    {
        Console.WriteLine("ДА");
    }
    else    
    {
        Console.WriteLine("НЕТ");
    }
}
Console.WriteLine("Введите число для поиска: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
NewArray(array);
Console.WriteLine($"{string.Join(", ", array)}");
FindArrayNumber(array, digit);