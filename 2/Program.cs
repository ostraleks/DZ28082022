/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей
суммой элементов: 1 строка
*/

int[,] array =
{
    {5, 0, 3, 1, 9, 0},
    {, 1, 3, 5, 1, 1},
    {9, 0, 6, 5, 1, 3}
};
int sumElements = 0;
int minimumSumma = int.MaxValue;
int minRow = 0;
for (int i = 0; i < array.GetLength(0); i++)//строчки
{
    for (int j = 0; j < array.GetLength(1); j++)// столбцы
    {
        sumElements += array[i, j];
    }
    Console.WriteLine($"Сумма элементов строки {i + 1} - {sumElements}");
    if (minimumSumma > sumElements)
    {
        minimumSumma = sumElements;
        minRow = i;
    }
     sumElements = 0;
}
Console.WriteLine($"Строка с минимальной суммой элементов - {minRow + 1}");
