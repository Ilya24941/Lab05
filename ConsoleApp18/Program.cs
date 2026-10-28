using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Лабораторна робота №5 | Варіант 13 ===");
            Console.WriteLine("--- Таблиця множення від 2 до 9 (цикл for) ---\n");

            // Шапка таблиці (множники від 2 до 9)
            Console.Write("    ");
            for (int j = 2; j <= 9; j++)
            {
                Console.Write($"{j,-4}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 36));

            // Рівень А: Основні вкладені цикли (версія через for)
            for (int i = 1; i <= 10; i++)
            {
                // Номер рядка (перший стовпець)
                Console.Write($"{i,-3}| ");

                for (int j = 2; j <= 9; j++)
                {
                    int product = i * j;
                    Console.Write($"{product,-4}");
                }
                Console.WriteLine();
            }

            /* 
            // Друга версія циклу (через while) для звіту:
            Console.WriteLine("\n--- Таблиця множення (версія while) ---");
            int row = 1;
            while (row <= 10)
            {
                Console.Write($"{row,-3}| ");
                int col = 2;
                while (col <= 9)
                {
                    Console.Write($"{row * col,-4}");
                    col++;
                }
                Console.WriteLine();
                row++;
            }
            */

            // Рівень Б: Малювання квадрата розміром n (від 3 до 20)
            Console.WriteLine("\n=== Рівень Б: Побудова фігури ===");
            int size;
            while (true)
            {
                Console.Write("Введіть розмір квадрата від 3 до 20: ");
                if (int.TryParse(Console.ReadLine(), out size) && size >= 3 && size <= 20)
                {
                    break;
                }
                Console.WriteLine("Помилка! Число має бути в діапазоні від 3 до 20.");
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Правило 1: Головна або побічна діагональ
                    if (i == j || i + j == size - 1)
                    {
                        Console.Write('#');
                    }
                    // Правило 2: Межі квадрата (рамка)
                    else if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write('*');
                    }
                    // Правило 3: Усі інші клітинки
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}