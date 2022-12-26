// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// ​m = 3, n = 4.
// ​0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9

double[,] CreateArray()
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[rows, columns];
    return matrix;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5:f1}", matr[i, j]));
        }
        Console.WriteLine();
    }
}

double[,] GetRandomMatrix(double[,] randmatr)
{
    Random rnd = new Random();
    for (int i = 0; i < randmatr.GetLength(0); i++)
    {
        for (int j = 0; j < randmatr.GetLength(1); j++)
        {
            randmatr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.00);
        }
    }
    return randmatr;
}

PrintArray(GetRandomMatrix(CreateArray()));