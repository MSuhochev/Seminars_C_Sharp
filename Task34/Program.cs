/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      array[i]  = new Random().Next(100, 1000);
    }
}
(int, int) EvenNumber(int[] array)
{
    int summeven = 0;
    int summodd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            summeven += array[i];
        }
        else
        {
            summodd += array[i];
        }

    }
    return (summeven, summodd);
}
int[] massive = new int[4];
NewArray(massive);
Console.WriteLine($"{string.Join(", ", massive)}");
(int summeven, int summodd) = EvenNumber(massive);
Console.WriteLine($"Сумма чётных элементов = {summeven}, нечётных = {summodd}");
