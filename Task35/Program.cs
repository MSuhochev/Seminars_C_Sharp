/*Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      array[i]  = new Random().Next(0, 151);
    }
}
int CountFindNumbers(int[] array)
{
    int findnumbers = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100)
        {
            findnumbers = findnumbers + 1;
        }
    }
    return (findnumbers);
}
int[] massive = new int[123];
NewArray(massive);
Console.WriteLine($"{string.Join(", ", massive)}");
int findnumbers = CountFindNumbers(massive);
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] = {findnumbers}");