// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить это невозможно

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

void PrintArray(int[,] array)
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

void ChangeRowsAndCols(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp; 
        }
    }
}

bool IsSquare(int[,] array)
{
    return (array.GetLength(0) == array.GetLength(1));
}

int n = 5;
int m = 5;
int[,] arr = CreateArray(m, n);
FillArray(arr, 1, 10);
PrintArray(arr);
if (IsSquare(arr))
{
    Console.WriteLine();
    ChangeRowsAndCols(arr);
    PrintArray(arr);
}
else
    Console.WriteLine("Невозможно заменить строки на столбы, т.к. матрица не квадратная");