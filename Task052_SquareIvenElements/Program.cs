// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue);
        }
    }
}

int[,] SquareEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j] * array[i,j];
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],2} ");  // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода
        }
    System.Console.WriteLine();
    }
}

int n = 4;
int k = 5;
int[,] arrayNew = CreateArray(n,k);
FillArray(arrayNew, -5, 6);                             // вызываем метод для заполнения массива числами [-5, 5]
PrintArray(arrayNew);
Console.WriteLine();
PrintArray(SquareEven(arrayNew));