// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

var arr = Generate2DArray(5, 5);
Print2DArray(arr);
Console.WriteLine();
GetMeSum(arr);

void GetMeSum(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sum = arr[i, j] + sum;
        }
        sum = sum / arr.GetLength(0);
        Console.Write(sum + "; ");
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    {
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                    result[i, j] = new Random().Next(1, 10);
            }
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
        {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
