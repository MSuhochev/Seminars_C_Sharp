/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void RandomArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}
int SumOddNum(int[] array)
{
    int sumodd = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 !=0)
        {
            sumodd += array[i];
        }
    }
    return(sumodd);
}

int[] array = new int[4];
RandomArray(array);
Console.WriteLine(string.Join(", ",array));
int sumodd = SumOddNum(array);
Console.WriteLine(sumodd);