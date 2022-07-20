/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/

void FillMatrix (int [,,] matrix)
{
    int num = 10;
    for(int k = 0; k < matrix.GetLength(0); k++)
    {
        for(int i = 0; i < matrix.GetLength(1); i++)
        {
            for(int j = 0; j < matrix.GetLength(2); j++)
            {
                matrix[k,i,j] = num;
                num +=5;
            }
        }
    }
}

static void PrintMatrix (int [,,] matrix)
{
    for(int k = 0; k < matrix.GetLength(0); k++)
    {
        for(int i = 0; i < matrix.GetLength(1); i++)
        {
            for(int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[k,i,j]} ({k},{i},{j}) ");
            }
            Console.WriteLine();
        }
    }
}

int [,,] matrix = new int [2,2,2];
FillMatrix(matrix);
PrintMatrix(matrix);
