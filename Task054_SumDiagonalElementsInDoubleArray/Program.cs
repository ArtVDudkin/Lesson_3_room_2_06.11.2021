// 54. В матрице чисел найти сумму элементов главной диагонали

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

int SumDiagonalElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i,j];
        }
    }
    return sum;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int m = 5;
int n = 5;
int[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew, -5, 6);                             // вызываем метод для заполнения массива числами [-5, 5]
PrintArray(arrayNew);
Console.WriteLine();
Console.WriteLine(SumDiagonalElements(arrayNew));