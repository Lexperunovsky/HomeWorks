/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int SumOfElements(int m, int n)
{
    if (m == n) return m;
    return n + SumOfElements(m, n - 1);
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {SumOfElements(m, n)}");