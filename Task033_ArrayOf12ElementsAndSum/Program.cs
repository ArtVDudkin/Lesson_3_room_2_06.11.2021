// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int FillArray()
{
    return new Random().Next(0, 10);             // заполняем элементы массива случайно значениями из [0,9]
}

int[] array = new int[12];                       // создаем массив из 12 элементов
int positive = 0;
int negative = 0;

Console.WriteLine("Массив из 12 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();
    Console.Write($"{array[index]} ");
    if (array[index] > 0) positive += array[index];
    if (array[index] < 0) negative += array[index];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {positive}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {negative}");