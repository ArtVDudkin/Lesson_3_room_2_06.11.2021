// 50. В двумерном массиве n×k заменить четные элементы на противоположные

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

int[,] IsEven (int[,] arr)                              // метод для нахождения четных элементов в двумерном массиве
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] % 2 == 0) 
                arr[i,j] *=-1;                          // если элемент четный, то заменяем его на противоположный
        }
    }
    return arr;
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

int n = 4;
int k = 5;
int[,] arrayNew = CreateArray(n,k);
FillArray(arrayNew, -5, 6);                             // вызываем метод для заполнения массива числами [-5, 5]
PrintArray(arrayNew);
Console.WriteLine();
PrintArray(IsEven(arrayNew));