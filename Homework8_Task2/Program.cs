//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int rows = 3;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SumOfRowsAndColumns(array);
Console.WriteLine($"Строка с наименьшей суммой - {SumOfRowsAndColumns(array)}");


//////////////////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] random = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            random[i, j] = new Random().Next(0, 10);
        }
    }
    return random;
}
int SumOfRowsAndColumns(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < 3; i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < 3; i++)
    {
        int sum = 0;
        for (int j = 0; j < 4; j++)
        {
            sum += array[i, j];
            if (minSum > sum)
            {
                minSum = sum;
                row = i;
            }
        }
    }
    return row;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}