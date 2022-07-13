/*
 * Реализовать метод нахождения n-го члена последовательности Фибоначчи по формуле F(n) = F(n-1) + F(n-2) с помощью рекурсивных вызовов.
Реализовать метод нахождения n-го члена последовательности Фибоначчи по формуле F(n) = F(n-1) + F(n-2) с помощью цикла.
Добавить подсчёт времени на выполнение рекурсивного и итеративного методов с помощью Stopwatch и написать сколько времени для значений 5, 10 и 20.
*/
using System.Diagnostics;

Fibonachi();

static void Fibonachi()
{
    var stopwatch = new Stopwatch();
    Console.WriteLine("Рекурсия");
    stopwatch.Start();
    int fib5 = FibonachiByRecursion(5);
    stopwatch.Stop();
    Console.WriteLine($"5 число Фибоначчи = {fib5}");
    Console.WriteLine($"FibonachiByRecursion {fib5} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();

    Console.WriteLine("Цикл");
    stopwatch.Start();
    int fibLoop5 = FibonachiByLoop(5);
    stopwatch.Stop();
    Console.WriteLine($"5 число Фибоначчи = {fibLoop5}");
    Console.WriteLine($"FibonachiByLoop {fibLoop5} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();
    Console.WriteLine("--------------");

    Console.WriteLine("Рекурсия");
    stopwatch.Start();
    int fib10 = FibonachiByRecursion(10);
    stopwatch.Stop();
    Console.WriteLine($"10 число Фибоначчи = {fib10}");
    Console.WriteLine($"FibonachiByRecursion {fib10} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();

    Console.WriteLine("Цикл");
    stopwatch.Start();
    int fibLoop10 = FibonachiByLoop(10);
    stopwatch.Stop();  
    Console.WriteLine($"10 число Фибоначчи = {fibLoop10}");
    Console.WriteLine($"FibonachiByLoop {fibLoop10} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();
    Console.WriteLine("--------------");

    Console.WriteLine("Рекурсия");
    stopwatch.Start();
    int fib20 = FibonachiByRecursion(20);
    stopwatch.Stop();
    Console.WriteLine($"10 число Фибоначчи = {fib20}");
    Console.WriteLine($"FibonachiByRecursion {fib20} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();

    Console.WriteLine("Цикл");
    stopwatch.Start();
    int fibLoop20 = FibonachiByLoop(20);
    stopwatch.Stop();
    Console.WriteLine($"10 число Фибоначчи = {fibLoop20}");
    Console.WriteLine($"FibonachiByLoop {fibLoop20} (Time: {stopwatch.Elapsed}");
    stopwatch.Reset();
    Console.WriteLine("--------------");

    static int FibonachiByRecursion(int n)
    {
        if (n == 0 || n == 1) return n;

        return FibonachiByRecursion(n - 1) + FibonachiByRecursion(n - 2);
    }

    static int FibonachiByLoop(int n)
    {
        int result = 0;
        int b = 1;
        int tmp;

        for (int i = 0; i < n; i++)
        {
            tmp = result;
            result = b;
            b += tmp;
        }
        return result;
    }
}
