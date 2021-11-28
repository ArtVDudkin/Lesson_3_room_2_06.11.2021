// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] CreateArray(int m, int n)                            // метод для создания двумерного массива m x n
{
    return new int [m,n];
}

void FillArray(int[,] array, int minValue, int maxValue)    // метод для заполнения двумерного массива целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] arr)                             // метод для вывода двумерного массива на экран
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода
            Console.Write($"{arr[i, j],2} ");  
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 5;
int[,] arrayNew = CreateArray(m,n);                     // создаем массив m x n
FillArray(arrayNew, 1, 10);                             // вызываем метод для заполнения массива числами [1, 9]
PrintArray(arrayNew);