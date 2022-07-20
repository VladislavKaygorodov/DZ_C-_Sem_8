/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

void CreateMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(10, 100);
        }
        Console.WriteLine();
    }
}

void PrintMatrix ( int [,] matrix )
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrixForLines(int [,] matrix)
{

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = 0;
        int temp = 0;
        int max = matrix [i,j];
        int size = matrix.GetLength(1);
        int count = matrix.GetLength(1) - 1;
        while(count > 0)
        {
            while(j < size)
            {
                if (matrix [i,j] < max)
                {
                    temp = matrix [i,j];
                    matrix [i,j] = max;
                    matrix [i,j-1] = temp;
                }
                if (matrix [i,j] > max)
                {
                    max = matrix [i,j];
                }
                j++;
            }
            count--;
            size--;
            j = 0;
            max = matrix [i,0];
        }
    }  
}

Console.WriteLine("Введите количество строк в матрице:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines,columns];

CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrixForLines(matrix);
PrintMatrix(matrix);