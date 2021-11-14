// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// int FillArray()                                 // функция для заполнения массива
// {
//     return new Random().Next(0, 10);            // заполняем элементы массива случайно значениями из [0,9]
// }

string DiffBetweenMinAndMax(double[] array)        // функция для расчета произведения пар элементов массива
{
    double max = array[0];                         // контейнер для максимального значения
    double min = array[0];                         // контейнер для минимального значения
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) max = array[index];      
        if (array[index] < min) min = array[index];
    }
    return $"Разница между максимальным элементом {max} и минимальным элементом {min} равна {Math.Round(max - min, 3)}";
}

double[] array = new double[10] {0.5, 1.5, 2.5, 3.1, 4.2, 0.2, 5.1, 6.1, 7.1, 5.7};             // создаем массив из 10 элементов


Console.WriteLine("Исходный массив элементов");
for (int index = 0; index < array.Length; index++)
{
    //array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]}  ");
}
Console.WriteLine();

Console.WriteLine(DiffBetweenMinAndMax(array));

