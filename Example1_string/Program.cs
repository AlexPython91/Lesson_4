using System;

// 

string[,] table = new string[2, 5];

// инициализация строк: String.Epmpty - пустая строка
// первый элемент,
// table[0, 0]    table[0, 1]    table[0, 2]     table[0, 4] - последний столбик
// макс индекс строки (1) так как строки всего 2
// table[1, 0]    table[1, 1]    table[1, 2]     table[1, 4] 

table[1, 2] = "слово";            // обращение к индексу строки и столбца

for (int rows = 0; rows < 2; rows++)  // цикл прохода по строкам
{
    for (int column = 0; column < 5; column++)   // цикл прохода по столбцам
    {
        Console.WriteLine($"--{table[rows, column]}-- ");  // Вывод в консоль
    }
    //Console.WriteLine();
}
