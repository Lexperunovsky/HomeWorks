/*  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int FunctionOfAkkerman(int m, int n)
{
    if (m == 0) 
    return n + 1;
    if (n == 0) 
    return FunctionOfAkkerman(m - 1, n);
    else 
    return FunctionOfAkkerman(m - 1, FunctionOfAkkerman(m,n - 1));
}

Console.WriteLine($"Если число m = {m}, а = {n} --> {FunctionOfAkkerman(m,n)} ");