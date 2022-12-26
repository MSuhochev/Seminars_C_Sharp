// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7   Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SumElementsRowsMatrix(int[,] matrix)
{
    int num = 0;
    int min = 1000;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            
        }
        if (sum < min)
        {
            min = sum;
            num = i;
        }
     
        Console.WriteLine($"Сумма элементов {i + 1}-й строки равна {sum}");
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: -  {num + 1}");
    Console.WriteLine();
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,3}", matr[i, j]);
        }
        Console.WriteLine();
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
Console.WriteLine();
int[,] matr = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matr);
Console.WriteLine();
SumElementsRowsMatrix(matr);