/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.WriteLine("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine());
int m = 1;

int NaturalNumbers(int n, int m)
{
    if (n == m) return n;
    else Console.WriteLine(NaturalNumbers(n,m+1));
    return m;
}

Console.WriteLine($"{NaturalNumbers(n,m)}");