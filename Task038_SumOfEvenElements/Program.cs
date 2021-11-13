// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(0, 10);            // заполняем элементы массива случайно значениями из [0,9]
}

int SumOfEvenElements(int[] array)              // функция для суммирования элементов массива, стоящих на нечетных позициях
{
    int sum = 0;
    for (int index = 0; index < array.Length; index +=2)
        sum += array[index];
    return sum;
}

int size = 20;                                  // задаем размерность массива
int[] array = new int[size];                    // создаем массив из size элементов

Console.WriteLine("Исходный массив элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна: {SumOfEvenElements(array)}");