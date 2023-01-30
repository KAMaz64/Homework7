/*  Задача 47: Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();

double[,] CreateNewRandomDoubleArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:F2}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите кол-во строк нового масива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите кол-во столбцов нового масива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("введите минимальное значение элемента нового масива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("введите верхний предел нового масива: ");
int max = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Двумерный массив вещественных чисел");
double[,] randomDoubleArray = CreateNewRandomDoubleArray(rows, columns, min, max);
PrintArray(randomDoubleArray);
