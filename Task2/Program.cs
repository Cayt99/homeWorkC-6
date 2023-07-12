// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program
{
    static void Main(string[] args)
    {
        double b1, k1, b2, k2;

        Console.Write("Введите значение b1: ");
        b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение k1: ");
        k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}; {y})");
    }
}
