//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");


double[,] array = GetDoubleArray(rows, columns);
PrintArray(array);


/////////////////////////////////////////////////////////////////

double[,] GetDoubleArray(int m, int n)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = (double)rnd.Next(-100, 100) / 10;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}
