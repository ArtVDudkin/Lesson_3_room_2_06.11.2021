// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(100, 1000);        // заполняем элементы массива случайно значениями из [100,999]
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());  
int[] array = new int[size];                    // создаем массив из size элементов
int ordinary = 0;
int even = 0;

Console.WriteLine("Исходный массив элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]} ");
    if (array[index] % 2 == 0) ordinary++;
    else even++;
}
Console.WriteLine();
Console.WriteLine($"Количество четный элементов в массиве: {ordinary}");
Console.WriteLine($"Количество нечетных элементов в массиве: {even}");