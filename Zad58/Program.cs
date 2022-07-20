/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/


void ProductMatrix ( int [,] firstMatrix, int [,] secondMatrix)
{
    int lines = firstMatrix.GetLength(0);
    int columns = firstMatrix.GetLength(1);
    int [,] OutputMatrix = new int [lines,columns];
    for(int i = 0; i < OutputMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < OutputMatrix.GetLength(1); j++)
        {
            OutputMatrix[i,j] = firstMatrix[i,j] * secondMatrix[i,j];
            Console.Write($"{OutputMatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void CreateMatrix (int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}

static void PrintMatrix (int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Write lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] firstMatrix = new int [lines,columns];
int [,] secondMatrix = new int [lines,columns];

CreateMatrix(firstMatrix);
PrintMatrix(firstMatrix);
CreateMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();
ProductMatrix(firstMatrix, secondMatrix);
