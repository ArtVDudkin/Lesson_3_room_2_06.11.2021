// 51. Задать двумерный массив следующим правилом: A[m,n] = m + n

int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int n = 4;
int k = 5;
int[,] arrayNew = CreateArray(n,k);
FillArray(arrayNew);
PrintArray(arrayNew);