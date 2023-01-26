/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
 
 int [,] array = new int[rows,columns];
 
 Random rnd = new Random();
 
  int [,]numbers = new int[rows,columns];
 
for (int i = 0; i < rows; ++i)
{
    for (int j = 0; j < columns; j++)
    {
       numbers[i,j] = rnd.Next(0,10);
        
    }
       
}
 

