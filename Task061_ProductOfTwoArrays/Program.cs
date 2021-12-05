// 61. Найти произведение двух матриц


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

int[,] ProductOfTwoMatrix(int[,] arrayA, int [,] arrayB)
{
    int[,] result = CreateArray(arrayA.GetLength(0), arrayB.GetLength(1));
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int res = 0; 
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                res += arrayA[i, k] * arrayB[k,j];
            }   
            result[i,j] = res;
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
int[,] arrayA = CreateArray(2,3);
int[,] arrayB = CreateArray(3,2);
if (arrayA.GetLength(1) != arrayB.GetLength(0))
    Console.WriteLine($"Ошибка! Количество столбцов матрицы А не совпадает с количеством строк матрицы В!");
else
{
    FillArray(arrayA, -9, 10);                             // вызываем метод для заполнения массива числами [-9, 9]
    FillArray(arrayB, 1, 10);                             // вызываем метод для заполнения массива числами [1, 9]
    int[,] arrayResult = CreateArray(arrayA.GetLength(0), arrayB.GetLength(1));//
    arrayResult = ProductOfTwoMatrix(arrayA, arrayB);
    PrintArray(arrayA);
    Console.WriteLine();
    PrintArray(arrayB);
    Console.WriteLine();
    PrintArray(arrayResult);
}
