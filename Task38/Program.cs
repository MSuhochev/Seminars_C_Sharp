/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void MyArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
int DiffOfNumbers(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    int don = max - min;
    return (don);
}
int[] myarray = new int[8];
MyArray(myarray);
Console.WriteLine(string.Join(", ", myarray));
int don = DiffOfNumbers(myarray);
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {don}");



