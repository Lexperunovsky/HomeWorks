/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
    Console.WriteLine(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int usNum);
    if (isCorrect)
        return usNum;
    Console.WriteLine(errorMessage);
    }
}

int SumNumbers(int sumNum)
{
    int sum = 0;
    while (sumNum > 0)
    {
        sum = sum + sumNum % 10;
        sumNum = sumNum / 10;
    }
    return sum;
}
int num = GetNumberFromUser("Введите число А: "," Ошибка ввода");
int a = SumNumbers(num);
Console.WriteLine($"Сумма чисел числа ({num}) = {a}");