// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
}

double[,] AverageInColumns(int[,] array)
{
    double[,] average = new double[1, array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];    
        average[0,j] = (double)sum / array.GetLength(0);
    }
    return average;
}

void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            Console.Write($"{array[i, j],2}\t");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0:f2}\t", array[i,j]));
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 6;
int[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew, 1, 10);                             // вызываем метод для заполнения массива числами [1, 9]
PrintArrayInt(arrayNew);
Console.WriteLine();
double[,] averageInCols = AverageInColumns(arrayNew);   // new double[1,n];
PrintArrayDouble(averageInCols);