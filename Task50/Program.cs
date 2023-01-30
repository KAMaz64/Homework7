/* Задача 50: Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого 
элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FindElementByPosition(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row > array.GetLength(0) || column > array.GetLength(1))
    { Console.WriteLine($"Такого числа нет в массиве"); }
    else Console.WriteLine($"Искомое число {array[row - 1, column - 1]}");
}

Console.Write("введите кол-во строк нового масива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите кол-во столбцов нового масива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("введите минимальное значение элемента нового масива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("введите верхний предел нового масива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GetArray(rows, columns, min, max);
PrintArray(newArray);
Console.WriteLine();

FindElementByPosition(newArray);

