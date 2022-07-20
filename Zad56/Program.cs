/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

void FindMinLine(int [,] matrix)
{
    int [] array = new int [matrix.GetLength(0)];
    int sum = 0;
    int k = 0;
    int minLine = 0;

    while(k < array.Length)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                sum +=matrix[i,j];
            }
            array[k] = sum;
            k++;
            sum = 0;
        }
    }
    k=0;

    Console.WriteLine();
    Console.WriteLine($"[{String.Join(";", array)}]");
    int min = array[k];
    while(k < array.Length)
    {
        if(min > array[k])
        {
            min = array[k];
            minLine = k + 1;
        }
        k++;
        if (minLine == 0) minLine =1;
    
    }
    Console.WriteLine($"Минимальная сумма элементов в линии составляет: {min}, линия {minLine}");
}

void CreateMatrix (int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10,100);
        }
        Console.WriteLine();
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


Console.WriteLine("Write lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [lines,columns];
CreateMatrix(matrix);
PrintMatrix(matrix);
FindMinLine(matrix);

