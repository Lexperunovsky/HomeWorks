/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
   
          
    Console.Write($"Введите количество элементов массива : ");
    int elementsCount = int.Parse(Console.ReadLine());
    int []array = new int[elementsCount];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\n ");
        array[i] = int.Parse(Console.ReadLine());
    }
    

    Console.Write("Вывод Массива");

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    } 

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
            Console.WriteLine($"Количество положительных чисел введенных пользователем = {count}");
        }
                
        
    }
  



/* int CheckPositiveNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) i++;
    }
    return array;
} */
