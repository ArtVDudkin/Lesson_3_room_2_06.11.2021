// 57. Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

void SortElementsArray(int[,] array, int toMax)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int k = j; k < array.GetLength(1); k++)
            {
                int minMax = array[i, j];
                if (toMax == 0)
                    if (array[i, k] > minMax)
                    {
                        minMax = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = minMax;
                    }  
                if (toMax == 1)
                    if (array[i, k] < minMax)
                    {
                        minMax = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = minMax;
                    }
            }
        }
    }
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
FillArray(arrayNew, 1, 10);                             // вызываем метод для заполнения массива числами [1, 9]
PrintArrayInt(arrayNew);
Console.WriteLine();
SortElementsArray(arrayNew, 0);                         // 1 - элементы по возрастанию, 0 - по убыванию
PrintArrayInt(arrayNew);