/*  Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.  0,5 7 -2 -0,2
               1 -3,3 8 -9,9
               8 7,8 -7,1 9   */


int rows = 0;
int columns = 0;
double min = 0d;
double max = 0d;

inputRowsColumns(ref rows, ref columns);
inputMinMax(ref min, ref max);
double[,] array = GetRandomArray(rows, columns, min, max);
PrintArray(array);
/////////////////////////////////////////////

void inputRowsColumns(ref int rows, ref int columns)
{
    try
    {
        Console.Write($"Введите количество строк: ");
        rows = int.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите количество столбцов: ");
        columns = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода!", ex);
    }
}

void inputMinMax(ref double min, ref double max)
{
    try
    {
        Console.Write($"Введите минимальное значение: ");
        min = double.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите максимальное значение: ");
        max = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода!", ex);
    }
}

double[,] GetRandomArray(double rows, double columns, double min, double max)
{
    double[,] result = new double[(int)rows, (int)columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
            result[i,j] = rnd.Next((int)min, (int)max);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    { 
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}
