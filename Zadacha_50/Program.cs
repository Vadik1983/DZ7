/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

int rows = 0;
int columns = 0;
double min = 0d;
double max = 0d;

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
    double[,] array = new double[(int)rows, (int)columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
            array[i,j] = rnd.Next((int)min, (int)max);
        }
    }
    return array;
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
/////////
int numRow = 0;
int numColumn = 0;
void InputNumber()
{
     try
    {
        Console.Write($"Введите номер строки: ");
        numRow = int.Parse(Console.ReadLine() ?? "");
        Console.Write($"Введите номер столбца: ");
        numColumn = int.Parse(Console.ReadLine() ?? "");
    }    
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка ввода!", ex);
    }
}

void VerificationNumber(double[,] inArray)
{
    
    
    if((numRow <= inArray.GetLength(0)) && (numColumn <= inArray.GetLength(1)))
    {
        Console.Write($"Число есть в массиве и рввно: {inArray[numRow - 1,numColumn - 1]}");
    }
        
    if((numRow > inArray.GetLength(0)) || (numColumn > inArray.GetLength(1)))
    {
        Console.Write($"Число не входит в массив!");
    }
}

inputRowsColumns(ref rows, ref columns);
inputMinMax(ref min, ref max);
double[,] array = GetRandomArray(rows, columns, min, max);
PrintArray(array);
InputNumber();
VerificationNumber(array);