/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

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

int Exponentiate(int a, int b)
{
    int mult = 1;
    for (int count = 1; count <= b; count++)
    {
        mult = mult * a;
    }
    return mult;
}
int num = GetNumberFromUser("Введите число А: "," Ошибка ввода");
int num2 = GetNumberFromUser("Введите число B: "," Ошибка ввода");
int stepen = Exponentiate(num, num2);
Console.WriteLine($"{num} в степени {num2} --> {stepen}");

