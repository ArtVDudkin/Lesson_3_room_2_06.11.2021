// 31. Задать массив из 8 элементов и вывести их на экран

int FillArray()
{
    return new Random().Next(1, 10);
}

int[] array = new int[8];

Console.WriteLine("Массив из 8 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();
    Console.Write($"{array[index]} ");
}
Console.WriteLine();