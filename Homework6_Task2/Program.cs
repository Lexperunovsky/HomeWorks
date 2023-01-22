/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1;
double k1;
double b2;
double k2;


while (true)
{

try 
{
    Console.WriteLine($"Введите значение точки b1");
    b1 = double.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Введите значение точки k1");
    k1= double.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Введите значение точки b2");
    b2 = double.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Введите значение точки k2");
    k2 = double.Parse(Console.ReadLine() ?? "");
    break;
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода! {exc.Message}");
}
}
if (k1!=k2) 
{
double x = (b2 - b1) / (k1 -k2);
double y = k1 * x + b1; 
Console.WriteLine($"Прямые пересекутся в : {x}; {y}");
}
else 
{
    Console.WriteLine($"Прямые являются параллельными");
}


