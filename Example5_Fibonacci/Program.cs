using System;

// Числа Фибоначчи

// для первого числа f(1) = 1
// для второго f(2) = 1
// для всех след. f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)   // тип метода int, название Fibonacci, возвр.арг число (n), можно double
{
    if (n == 1 || n == 2) return 1;            // если n == 1, или n == 2, то возвращаем n
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)        // Цикл от 1 до 10
{
    Console.WriteLine($"({i}) = {Fibonacci(i)} ");
}
