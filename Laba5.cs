using System;

class Program
{
    // -----------------------------------------------
    // Лабораторная работа №5
    // Методы с параметрами и без.
    // Варианты передачи параметров: по значению, по ссылке, out, params.
    // -----------------------------------------------

    // === УПРАЖНЕНИЕ 5.1 ===
    //Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода два целых числа. Протестировать метод. Ведите два числа:
    static void task_1()
    {
        Console.WriteLine("Упражнение 5.1 — Наибольшее из двух чисел");
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int result = MaxOfTwo(a, b);
        Console.WriteLine($"Наибольшее число: {result}\n");
    }

    static int MaxOfTwo(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // === УПРАЖНЕНИЕ 5.2 ===
    //Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых параметров. Параметры передавать по ссылке.
    static void task_2()
    {
        Console.WriteLine("Упражнение 5.2 — Обмен значений");
        int x = 5, y = 10;
        Console.WriteLine($"До Swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"После Swap: x = {x}, y = {y}\n");
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // === УПРАЖНЕНИЕ 5.3 ===
    // Метод вычисления факториала с проверкой переполнения (out параметр)
    // Вычисляет факториал числа n. Если число слишком большое — сообщает об ошибке
    static void task_3()
    {
        Console.WriteLine("Упражнение 5.3 — Факториал с проверкой переполнения");
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        if (Factorial(n, out long result))
            Console.WriteLine($"Факториал {n} = {result}\n");
        else
            Console.WriteLine("Ошибка: переполнение!\n");
    }

    static bool Factorial(int n, out long result)
    {
        result = 1;
        try
        {
            checked
            {
                for (int i = 2; i <= n; i++)
                    result *= i;
            }
            return true;
        }
        catch (OverflowException)
        {
            result = 0;
            return false;
        }
    }

    // === УПРАЖНЕНИЕ 5.4 ===
    // Рекурсивный метод вычисления факториала
    static void task_4()
    {
        Console.WriteLine("Упражнение 5.4 — Рекурсивный факториал");
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Факториал {n} = {FactorialRecursive(n)}\n");
    }

    static long FactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursive(n - 1);
    }

    // === ДОМАШНЕЕ ЗАДАНИЕ 5.1 ===
    // Метод, вычисляющий НОД двух и трёх чисел
    static void task_5()
    {
        Console.WriteLine("Домашнее задание 5.1 — НОД двух и трёх чисел");
        Console.WriteLine($"НОД(24, 36) = {GCD(24, 36)}");
        Console.WriteLine($"НОД(24, 36, 60) = {GCD(24, 36, 60)}\n");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int GCD(int a, int b, int c)
    {
        return GCD(GCD(a, b), c);
    }

    // === ДОМАШНЕЕ ЗАДАНИЕ 5.2 ===
    // Рекурсивный метод вычисления n-го числа Фибоначчи
    static void task_6()
    {
        Console.WriteLine("Домашнее задание 5.2 — Число Фибоначчи");
        Console.Write("Введите номер числа Фибоначчи: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"F({n}) = {Fibonacci(n)}\n");
    }

    static long Fibonacci(int n)
    {
        if (n <= 2) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // === Точка входа ===
    static void Main()
    {
        // Вызываем все задания по порядку
        task_1();
        task_2();
        task_3();
        task_4();
        task_5();
        task_6();

        Console.WriteLine("Все задания лабораторной №5 выполнены!");
    }
}
