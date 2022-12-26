// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:              В итоге получается вот такой массив:
//                         1 4 7 2                  >>>>                    1 2 4 7
//                         5 9 2 3                  >>>>                    2 3 5 9
//                         8 4 2 4                  >>>>                    2 4 4 8

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

void SortAscendingMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] >= matrix[i, k]) continue;
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, k];
            matrix[i, k] = temp;
        }

for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0,4}", matrix[i, j]);
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,4}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
Console.WriteLine();
int[,] matr = GetRandomMatrix(rowsCount, columnsCount);
Console.WriteLine("Исходная рандомная матрица:");
PrintMatrix(matr);
Console.WriteLine();
Console.WriteLine("Отсортированная построчно матрица:");
SortAscendingMatrix(matr);
Console.WriteLine();