// 63. Сформировать трехмерный массив не повторяющимися двузначными числами, показать его построчно на экран выводя индексы соответствующего элемента

int[, ,] CreateArray(int m, int n, int k)
{
    return new int [m,n, k];
}

void FillArray(int[, ,] array)
{
    int value = 10;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[m,n,k] = value++;
                }
        }
    }
}

void PrintArrayInt(int[, ,] array)
{
    // for (int m = 0; m < array.GetLength(0); m++)
    // {
    //     for (int n = 0; n < array.GetLength(1); n++)
    //     {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
    //         Console.Write($"{array[i, j],2} ");
    //     }
    //     Console.WriteLine();
    // }

    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"{m} {n} {k} = {array[m,n,k]}");
                }
        }
    }
}

Console.Clear();
int m = 4;
int n = 3;
int k = 7;
if (m*n*k > 90)
    Console.WriteLine($"Ошибка! Невозможно заполнить трехмерный массив {m}x{n}x{k} неповторяющимися двузначными числами! Введите меньшую размерность массива.");
else
{
    int[, ,] arrayNew = CreateArray(m,n,k);
    FillArray(arrayNew);
    PrintArrayInt(arrayNew);
}