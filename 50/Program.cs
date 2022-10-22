/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента) */

int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
Console.Write("Введите номер строки искомого элемента массива: ");
int rowIndex = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента массива: ");
int columnIndex = int.Parse(Console.ReadLine());
Console.WriteLine();
FindElement(array, rowIndex, columnIndex);

void FindElement(int[,] array, int rowIndex, int columnIndex)
{
    if (rowIndex < 0 || rowIndex > array.GetLength(0) - 1 || columnIndex < 0 || columnIndex > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine(array[rowIndex, columnIndex]);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] matr)
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