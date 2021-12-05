// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

(int, int) FindMinElement(int[,] array, int isMax)          // метод для нахождения индексов минимального/максимального элемента в массиве
{
    int row = 0;
    int col = 0;
    int minimax = array[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (isMax == 0)                                 // ищем минимальный элемент
                if (array[i, j] < minimax)
                {
                    minimax = array[i, j];
                    row = i;
                    col = j;
                }  
            if (isMax == 1)                                 // ищем максимальный элемент
                if (array[i, j] > minimax)
                {
                    minimax = array[i, j];
                    row = i;
                    col = j;
                }
        }     
    }
    return (row, col);
}

int[,] DeleteRowAndColArray(int[,] array, (int row, int col) coord)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] result = CreateArray(row -1, col -1);
    for (int i = 0; i < row -1; i++)
    {
        for (int j = 0; j < col -1; j++)
        {
            if ( (i < coord.row) && (j < coord.col) )
                result[i,j] = array[i,j];
            if ( (i >= coord.row) && (j < coord.col) )
                result[i,j] = array[i +1,j];
            if ( (i < coord.row) && (j >= coord.col) )
                result[i,j] = array[i,j +1];
            if ( (i >= coord.row) && (j >= coord.col) )
                result[i,j] = array[i +1,j +1];
        }
    }
    return result;
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

Console.Clear();
int m = 5;
int n = 8;
int[,] arrayOrigin = CreateArray(m,n);
FillArray(arrayOrigin, 1, 10);                             // вызываем метод для заполнения массива числами [1, 9]
PrintArray(arrayOrigin);
(int, int) coord = FindMinElement(arrayOrigin, 0);         // 0 - ищем минимальный элемент, 1 - ищем максимальный элемент
Console.WriteLine();
Console.WriteLine($" Удаляем строку и столбец: {coord}");
int[,] arrayNew = CreateArray(m -1, n -1);
arrayNew = DeleteRowAndColArray(arrayOrigin, coord);
PrintArray(arrayNew);