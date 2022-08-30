/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] arrayA =
{
    {2, 4},
    {3, 2}
};
int[,] arrayB =
{
    {3, 4},
    {3, 3}
};
// по условиям задачи разамерность массива А совпадает с размерностью массива В
int dimensionRow = arrayA.GetLength(0);
int dimensionColumns = arrayA.GetLength(1);
int[,] arrayC = new int[dimensionRow, dimensionColumns];
for (int i = 0; i < dimensionRow; i++)
{
    for (int j = 0; j < dimensionColumns; j++)
    {
        for (int k = 0; k < dimensionColumns; k++)
        {
            arrayC[i, j] += (arrayA[i, k] * arrayB[k, j]);
        }
    }
}
    for (int i = 0; i < dimensionRow; i++)
    {
        for (int j = 0; j < dimensionColumns; j++)
        {
            Console.Write(arrayC[i, j] + "\t");
        }
        Console.WriteLine();
    }
