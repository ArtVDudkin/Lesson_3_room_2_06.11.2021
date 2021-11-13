// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int FillArray()
{
    return new Random().Next(0, 2);             // заполняем элементы массива случайно значениями из [0,1]
}

int[] array = new int[8];                       // создаем массив из 8 элементов

Console.WriteLine("Массив из 8 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();
    Console.Write($"{array[index]} ");
}
Console.WriteLine();