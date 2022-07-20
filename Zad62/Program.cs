/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1  2  3 4
12 13 14 5
11 16 15 6
10  9  8 7*/

void SpiralMatrix(int [,] matrix)
{
    int N = 0;
    int num = 10;
    int lineSize = matrix.GetLength(0) - 1;
    int columnSize = matrix.GetLength(1) - 1;
    int size = matrix.GetLength(0) * matrix.GetLength(1) + 1;
    int count = 0;
    while(count < size)
    {
        for(int i = 0; i < lineSize - N; i++)
        {
            if(count > size)
            {
                break;
            }
            matrix[0 + N,i + N] = num;
            num++;
            count = count+ 1;
        }   
        num = num - N;
        for(int j = 0; j < columnSize - N; j++)
        {
            if(count > size)
            {
                break;
            }
            matrix[j + N,3 - N] = num;
            num++;
            count = count+ 1;
        }
        num = num - N;
        for(int k = 3; k > 0 + N; k--)
        {
            if(count > size)
            {
                break;
            }
            matrix[3 - N,k - N] = num;
            num++;
            count = count+ 1;
        }
        for( int z = 3 - N; z > 0 + N; z--)
        {
            if(count > size)
            {
                break;
            }
            matrix[z - N,0 + N] = num;
            num++;
            count = count+ 1;
        }
        N++;
        //Console.Write($"count = {count} ");
    }
}

void PrintMatrix (int [,] matrix)
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

int [,] matrix = new int [4,4];
PrintMatrix(matrix);
SpiralMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
