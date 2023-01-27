/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int rows = 0;
int columns = 0;
int min = 0;
int max = 0;

inputRowsColumns(ref rows, ref columns, ref min, ref max);
int[,] array = GetRandomArray(rows, columns, min, max);
PrintArray(array);
AverageNum(array);
/////////////////////////////////////////////

void inputRowsColumns(ref int rows, ref int columns, ref int min, ref int max)
{
    try
    {
        Console.Write($"Введите количество строк: ");
        rows = int.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите количество столбцов: ");
        columns = int.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите минимальное значение: ");
        min = int.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите максимальное значение: ");
        max = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода!", ex);
    }
}

int[,] GetRandomArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[(int)rows, (int)columns];
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

void PrintArray(int[,] inArray)
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

void AverageNum(int[,] array)
{
    int i = 0;
    int j = 0;
    double sum = 0;
    double average = 0;
    
    for(j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for(i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
            average = Math.Round(sum / (array.GetLength(0)));
        }
        
        Console.WriteLine($"Среднее арифметическое столбца {j} = {average}"); 
    }
    
}