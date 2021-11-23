using System;

// Вычисление факториала

double Factorial(int n)
{
    if (n == 1) return 1;              // Если факториал = 1 - возвращаем 1
    else return n * Factorial(n - 1);   // если нет то умножаем тек. значение (n) и умножить на предыдущие число 
}
//Console.WriteLine(Factorial(3));     // выводим факториал 3 (1*2*3 = 6)

for (int i = 1; i < 40; i++)
    {
        Console.WriteLine($"{i}! = {Factorial(i)} ");    // Stack overflow ((
    }