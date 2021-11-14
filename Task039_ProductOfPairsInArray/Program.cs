// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(0, 10);            // заполняем элементы массива случайно значениями из [0,9]
}

int ProductOfPairs(int first, int last)         // функция для расчета произведения пар элементов массива
{
    return first*last;
}

int size = 11;                                  // задаем размерность массива
int[] array = new int[size];                    // создаем массив из size элементов

Console.WriteLine($"Исходный массив из {array.Length} элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]} ");
}
Console.WriteLine();

for (int index = 0; index < array.Length / 2; index++)
{
    Console.WriteLine($"Произведение пары {array[index]} х {array[array.Length -1 - index]} = {ProductOfPairs(array[index], array[array.Length -1 - index])}");
}
