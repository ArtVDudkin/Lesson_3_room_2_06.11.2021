// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int FindRowMinimalSum(int[,] array)
{
    double[,] average = new double[1, array.GetLength(1)];
    int minimalSum = 0;
    int rowMinSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];    
        if (i == 0) 
        {
            minimalSum = sum;
            rowMinSum = i;
        }
        else
        {
            if (sum < minimalSum)
            {
                minimalSum = sum;
                rowMinSum = i;
            }
        }
    }
    return rowMinSum;
}

void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 6;
int[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew, -9, 10);                             // вызываем метод для заполнения массива числами [-9, 9]
PrintArrayInt(arrayNew);
Console.WriteLine();
Console.WriteLine(FindRowMinimalSum(arrayNew));