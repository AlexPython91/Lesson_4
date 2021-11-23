using System;

// Печать массива: Метод тип void/ название PrintArray/ аргумент двуменрый массив

void PrintArray(int[,] matr)   // Меняем название на matr
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод заполнения массива тип void/ название PrintArray/ аргумент двуменрый массив

void FillArray(int[,] matr)   // Меняем название на matr
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 6];
PrintArray(matrix);     // Вызов метода печати
Console.WriteLine();    // Пробел между массивами 
FillArray(matrix);       // Вызов метода заполнения массива
PrintArray(matrix);     // Печать заполненного массива