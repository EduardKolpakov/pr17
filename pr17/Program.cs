using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Шаг 1: Создание матрицы и её заполнение случайными числами
        const int rows = 100;
        const int cols = 50;
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        // Заполняем матрицу случайными числами
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-1000, 1001);
            }
        }

        // Шаг 2: Вычисление средних арифметических для каждой строки матрицы
        double[] averages = new double[rows];

        for (int i = 0; i < rows; i++)
        {
            // Используем LINQ для вычисления среднего арифметического
            averages[i] = matrix.Cast<int>().Skip(i * cols).Take(cols).Average();
        }

        // Шаг 3: Вывод первых 10 средних значений
        Console.WriteLine("Первые 10 средних значений:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {averages[i]:F2}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}