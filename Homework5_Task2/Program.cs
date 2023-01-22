/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
int[] array = GetRandomArray(6, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
int oddNumber = SumOddNumbers(array);
Console.WriteLine($"Сумма нечетных чисел массива = {oddNumber}");

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

int SumOddNumbers(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumOdd += array[i];
    }
    return sumOdd;
}


