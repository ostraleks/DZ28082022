/*
Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine();
int[,] newArray = new int[rows, columns];
int minimum = int.MaxValue;
int indexMinimum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = (columns - 1); j >= 0; j--)
    {
        for (int k = 0; k < columns; k++)
        {
            if (minimum > resultMatrix[i, k])
            {
                minimum = resultMatrix[i, k];
                indexMinimum = k;
            }
        }
        resultMatrix[i, indexMinimum] = int.MaxValue;
        newArray[i, j] = minimum;
        minimum = int.MaxValue;
    }
}
Console.WriteLine("Упорядоченная матрица: ");
PrintArray(newArray);
