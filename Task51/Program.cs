// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
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
int GetSumMainDiagonal(int[,] matr)
{
    int sum = 0;
    int min = matr.GetLength(0);
    if (matr.GetLength(0) > matr.GetLength(1))
    {
        min = matr.GetLength(1);
    }

    for(int i = 0; i < min; i++)
    {
        sum += matr[i, i];
    }
    return sum;
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
Console.WriteLine();
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма главной диагонали матрицы = {GetSumMainDiagonal(matrix)}");
