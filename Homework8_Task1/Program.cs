//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine($"\nОтсортированный массив:  ");


////////////////////////////////////////////////

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

void SortArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[i, j - 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j - 1];
                array[i, j - 1] = temp;
            }

        }
    }

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