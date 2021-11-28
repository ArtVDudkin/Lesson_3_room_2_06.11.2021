// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateArray(int m, int n)                     // метод для создания двумерного массива m x n
{
    return new double[m,n];
}

void FillArray(double[,] array)                         // метод для заполнения двумерного массива вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*100;
        }
    }
}

void PrintArray(double[,] arr)                          // метод для вывода двумерного массива на экран
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   // String.Format("{0:f2}\t", arr[i,j]) оставляем 2 знака после запятой для красивого вывода
            Console.Write(String.Format("{0:f2}\t", arr[i,j]));
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 5;
double[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew);
PrintArray(arrayNew);