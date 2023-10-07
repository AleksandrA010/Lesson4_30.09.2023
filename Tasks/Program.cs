using System;

namespace Tasks
{
    internal class Program
    {
        static int Arith(ref int product_numbers, out double arithmetic_mean, params int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                product_numbers *= array[i];
            }
            arithmetic_mean = Math.Round(result / (double) array.Length, 2);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.\n");
            Console.WriteLine("\nЗадание 2.\n");
            Console.WriteLine("\nЗадание 3.\n");
            Console.WriteLine("\nЗадание 4.\n");

            bool flag = true;
            while (flag)
            {
                Console.Write("\nВведите номер задания для проверки или break для выхода из приложения: ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        int[] ints = new int [20];
                        Random rand = new Random();
                        Console.WriteLine("Дан массив из 20-ти случайных чисел, введите порядковые номер двух чисел, которые нужно поменять.\n");
                        for (int i = 0; i < ints.Length; i++)
                        {
                            ints[i] = rand.Next(-1000, 1000);
                            Console.Write($" {ints[i]}");
                        }
                        Console.Write("\n\nВведите первый номер: ");
                        int.TryParse(Console.ReadLine(), out int number1);
                        Console.Write("Введите второй номер: ");
                        int.TryParse(Console.ReadLine(), out int number2);
                        int value1 = ints[number1 - 1];
                        int value2 = ints[number2 - 1];
                        ints[number1 - 1] = value2;
                        ints[number2 - 1] = value1;
                        Console.WriteLine("\nВаш изменённый массив: ");
                        for (int i = 0; i < ints.Length; i++)
                        {
                            Console.Write($" {ints[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("Введите количество элекметов в массиве: ");
                        int.TryParse(Console.ReadLine(), out int size);
                        int[] ints2 = new int[size];
                        int num = 0;
                        int product_numbers = 1;
                        double arithmetic_mean = 0;
                        for (int i = 0; i < ints2.Length; i++)
                        {
                            Console.Write($"Введите {i+1}-ый элемент массива: ");
                            int.TryParse(Console.ReadLine(), out num);
                            ints2[i] = num;
                        }
                        Console.WriteLine($"\nСумма элементов вашего массива — {Arith(ref product_numbers, out arithmetic_mean, ints2)}.\nПроизведение элементов вашего массива — {product_numbers}.\nСреднее арифметическое вашего массива — {arithmetic_mean}.");

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "break":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Такого задания нет.");
                        break;
                }
            }
        }
    }
}
