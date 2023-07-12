// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 

using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int m = Prompt("Введите количество чисел: ");

        for (int i = 0; i < m; i++)
        {
            int number = Prompt($"Введите число #{i + 1}: ");
            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больше 0: {count}");
    }

    static int Prompt(string message)
    {
        Console.Write(message);
        string value = Console.ReadLine();
        int result;
        while (!int.TryParse(value, out result))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            Console.Write(message);
            value = Console.ReadLine();
        }
        return result;
    }
}
