// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2      и     1 5 8 5   Их произведение будет    1 20 56 10
// 5 9 2 3            4 9 4 2   равно следующему         20 81 8 6
// 8 4 2 4            7 2 2 6   массиву:                 56 8 4 24
// 5 2 6 7            2 3 4 7                            10 6 24 49

int[,] GetRandomMatrix(int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[4, 4];
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

int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] productMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            productMatrix[i, j] += matrixA[i, j] * matrixB[i, j];
        }
    }
    return productMatrix;
}

int[,] onematrix = GetRandomMatrix();
Console.WriteLine("Первая матрица:");
PrintMatrix(onematrix);
Console.WriteLine();
int[,] secondmatrix = GetRandomMatrix();
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondmatrix);
Console.WriteLine();
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(ProductMatrix(onematrix, secondmatrix));

