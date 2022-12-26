// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int tmp = 0;
int n = array.GetLength(1);
for (int j = 0; j < array.GetLength(1); j++)
{
    tmp = array[0, j];
    array[0, j] = array[n - 1, j];
    array[n - 1, j] = tmp;
}

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j]);
    }
    Console.WriteLine();
}


