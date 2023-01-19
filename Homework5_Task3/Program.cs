/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */
int[] array = GetRandomArray(10, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
DiffOfMaxMinArray(array);
Console.WriteLine($"Разница между максимальным и минимальным эллементом массива = {DiffOfMaxMinArray(array)}");

int DiffOfMaxMinArray(int[]array)
{
    int max = array[0];
    int min = array[0];
    int result;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)   min = array[i];
        {
            if (array[i] > max) max = array[i];
        }
           
        
    }
    return result = max - min;
}
 int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}