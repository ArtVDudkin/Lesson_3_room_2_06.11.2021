// 34. Написать программу замену элементов массива на противоположные

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(-9, 10);           // заполняем элементы массива случайно значениями из [-9,9]
}

int ReplaceArray(int n)                         // функция для замены элементов на противоположные
{
    return -1*n;                                // возвращаем инвертированное значение элемента массива
}

int[] array = new int[12];                      // создаем массив из 12 элементов

Console.WriteLine("Исходный массив из 12 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();
    Console.Write($"{array[index]} ");
}
Console.WriteLine();
Console.WriteLine("Массив с элементами, замененными на противоположные");
for (int index = 0; index < array.Length; index++)
{
    array[index] = ReplaceArray(array[index]);
    Console.Write($"{array[index]} ");
}
Console.WriteLine();