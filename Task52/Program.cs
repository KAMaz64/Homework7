/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

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

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        double sum=0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum+=array[row,column];
        }
        result[column]=Math.Round(sum/array.GetLength(0),2);
    }
    return result;
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

double[] arithmeanColumns=GetResultArray(newArray);
Console.WriteLine($"Среднее фрифметическое столбцов: {String.Join("; ", arithmeanColumns)}");
