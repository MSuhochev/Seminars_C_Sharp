// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetGivenMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

        for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }

    return matr;
}
void SquareMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i += 2)
    {
        for (int j = 0; j < matr.GetLength(1); j += 2)
        {
            matr[i, j] *= matr[i, j];
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetGivenMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
SquareMatrix(matrix);
PrintMatrix(matrix);
