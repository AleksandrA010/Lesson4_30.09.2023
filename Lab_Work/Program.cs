using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Lab_Work
{
    internal class Program
    {
        static int Max(int value1, int value2)
        {
            int result;
            if (value1 >= value2)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            return result;
        }
        static void Reverse(ref int value1, ref int value2)
        {
            int x = value2;
            value2 = value1;
            value1 = x;
        }
        static bool Factorial(int number, out int result)
        {
            bool bool_result = true;
            result = 1;
            checked
            {
                for (int i = 1; i <= number; i++)
                {
                    try
                    {
                        result = checked(result * i);
                    }
                    catch (OverflowException)
                    {
                        bool_result = false;
                    }
                }
            }
            return bool_result;
        }
        static decimal Factorial_Re(int number)
        {
            if (number == 1) return 1;
            else return number * Factorial_Re(number - 1);
        }
        static int GCD(int value1, int value2)
        {
            while (value1 != value2)
            {
                if (value1 > value2)
                {
                    value1 = value1 - value2;
                }
                else
                {
                    value2 = value2 - value1;
                }
            }
            return value2;
        }
        static int GCD(int value1, int value2, int value3)
        {
            value1 = GCD(value1, value3);
            while (value1 != value2)
            {
                if (value1 > value2)
                {
                    value1 = value1 - value2;
                }
                else
                {
                    value2 = value2 - value1;
                }
            }
            return value2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.\n");
            Console.WriteLine("Задание 2.\n");
            Console.WriteLine("Задание 3.\n");
            Console.WriteLine("Задание 4.\n");
            Console.WriteLine("Задание 5.\n");
            Console.WriteLine("Задание 6.\n");

            bool flag = true;
            while (flag)
            {
                Console.Write("\nВведите номер следующего задания или break для выхода: ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Console.Write("Введите первое целое число: ");
                        int.TryParse(Console.ReadLine() , out int value1);
                        Console.Write("Введите второе целое число: ");
                        int.TryParse(Console.ReadLine(), out int value2);
                        Console.WriteLine($"Наибольшее из двух чисел — {Max(value1, value2)}");
                        break;
                    case "2":
                        Console.Write("Введите первое целое число: ");
                        int.TryParse(Console.ReadLine(), out value1);
                        Console.Write("Введите второе целое число: ");
                        int.TryParse(Console.ReadLine(), out value2);
                        Reverse(ref value1, ref value2);
                        Console.WriteLine($"Первое число — {value1};\nВторое число — {value2}");
                        break;
                    case "3":
                        Console.Write("Введите первое целое число: ");
                        int.TryParse(Console.ReadLine(), out int number1);
                        bool flag_number = Factorial(number1, out int result);
                        if (flag_number)
                        {
                            Console.WriteLine($"Факториал числа {number1}! = {result}.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка переполнения.");
                        }
                        break;
                    case "4":
                        Console.Write("Введите целое число: ");
                        int.TryParse(Console.ReadLine(), out int number2);
                        Console.WriteLine($"Факториал числа {number2}! = {Factorial_Re(number2)}");
                        break;
                    case "5":
                        Console.Write("Введите первое целое число: ");
                        int.TryParse(Console.ReadLine(), out int int1);
                        Console.Write("Введите второе целое число: ");
                        int.TryParse(Console.ReadLine(), out int int2);
                        Console.WriteLine($"НОД({int1}, {int2}) = {GCD(int1, int2)}");
                        Console.Write("Введите третье целое число: ");
                        int.TryParse(Console.ReadLine(), out int int3);
                        Console.WriteLine($"НОД({int1}, {int2}, {int3}) = {GCD(int1, int2, int3)}");
                        break;
                    case "6":
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
