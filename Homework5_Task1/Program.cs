/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

 int[] array = GetRandomArray(4, 0, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int evenNumber = EvenNumberInArray(array);
Console.WriteLine($"Количетсво четных чисел = {evenNumber}");

///////////////////////////////////////
int EvenNumberInArray(int []array)
{
    int even = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0) even++;
}
return even;
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