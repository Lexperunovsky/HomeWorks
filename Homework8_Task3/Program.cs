//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк первого массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов первого массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите количество строк второго массива: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов второго массива: ");
int columns1 = int.Parse(Console.ReadLine() ?? "");
if (columns != rows1)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] mult = MultiplicationOfArray(array,array1);
PrintArray(mult);
/////////////////////////////////////////////////////////////////////

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
int [,] MultiplicationOfArray(int [,] array1, int [,] array2) 
{
    int [,] result = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i,j] += array1[i,k] * array2[k,j]; 
            }
        }
    }
    return result;
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

