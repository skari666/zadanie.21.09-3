using System;

class Program
{
    static void Main()
    {
        // Введите координаты первой точки
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        // Введите координаты второй точки
        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Вычисление коэффициента 
        double k = (y1 - y2) / (x1 - x2);

        // Вычисление b
        double b = y2 - k * x2;

        // Вывод уравнения прямой
        Console.WriteLine($"Уравнение прямой: y = {k:F2}x + {b:F2}");
        Console.ReadKey();
    }
}
