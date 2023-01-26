//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns);
PrintArray(array);

GetPositionArray(array);
/////////////////////////////////////////////////////

int[,] GetArray(int m, int n)
{
    Random rnd = new Random();
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(0, 10);
        }
    }
    return result;
}
 
 

void GetPositionArray(int [,] positionArray)
{
     Console.WriteLine("Введите координаты позиции числа массива: ");
    int coordinateFirst = Convert.ToInt32(Console.ReadLine());
    int coordinateSecond = Convert.ToInt32(Console.ReadLine());

    if (coordinateFirst > rows && coordinateSecond > columns)
    {
        Console.WriteLine("Такой позиции нет");        
    }
    else 
    {
        object result = positionArray.GetValue(coordinateFirst,coordinateSecond) ?? "";
        System.Console.WriteLine($"Координаты введенного числа => {result}");
    }
    
}
void PrintArray(int[,] inArray)
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



































/* Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 } */