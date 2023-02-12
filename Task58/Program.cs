/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int [,] GetMultipMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int f = 0; f < matrixA.GetLength(0); f++)
    {
        for (int i = 0; i < matrixA.GetLength(1); i++)
        {
            for (int j = 0; j < matrixA.GetLength(0); j++)
            {
                matrixC[f,i] = matrixC[f,i]+(matrixA[f, j] * matrixB[j, i] );
                
            }
        }

    }
    return matrixC;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrixA = (Generate2DArray(2, 2));
Print2DArray(matrixA);
Console.WriteLine();

int[,] matrixB = (Generate2DArray(2, 2));
Print2DArray(matrixB);
Console.WriteLine();

Print2DArray(GetMultipMatrix(matrixA,matrixB));
Console.WriteLine();
