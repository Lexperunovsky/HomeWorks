//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите третье пространство массива: ");
int height = int.Parse(Console.ReadLine() ?? "");

double[,,] array = GetArray(rows, columns, height, 0, 100);
PrintArray(array);

///////////////////////////////////////////////////////////////////////////////////////////////
double[,,] GetArray(int rows, int columns, int height, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,,] random = new double[rows, columns, height];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < height; k++)
            {
                random[i, j, k] = (double)rnd.Next(-1000, 1000) / 10;
            }
        }
    }
    return random;
}
void PrintArray(double[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           for (int k = 0; k < inArray.GetLength(2); k++)
           {
             Console.Write($" {inArray[i, j, k]} ");
           }
        }
        Console.WriteLine(" ");
    }
}