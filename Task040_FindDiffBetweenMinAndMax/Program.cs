// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] CreateArray(int count)                 // функция для создания массива вещественных чисел
// {
//     return new int[count];                      // размерности count, по умолчанию заполнен нулями
// }

// void FillArray(double[] array, double minValue, double maxValue)     // функция для заполнения массива
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);   // заполняем случайными числами от minValue до maxValue
//     }
// }

string PrintArray(double[] array)                  // функция для вывода массива на экран
{
    int count = array.Length;                   
    string res = String.Empty;                     // создаем пустую строку
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]}  ";                    // формируем строку для вывода на экран
    }
    return res;
}

double FindMax(double[] array)                     // функция для нахождения максимального элемента в массиве
{
    double max = array[0];                         // контейнер для максимального значения
    int count = array.Length;           
    for (int index = 0; index < count; index++)
        if (array[index] > max) max = array[index];      
    return max;
}

double FindMin(double[] array)                     // функция для нахождения минимального элемента в массиве
{
    double min = array[0];                         // контейнер для минимального значения
     int count = array.Length;           
    for (int index = 0; index < count; index++)   
        if (array[index] < min) min = array[index];
    return min;
}

Console.Clear();
// double[] arr = CreateArray(10);                 // создаем вещественный массив из 10 элементов
double[] array = new double[10] {0.5, 1.5, 2.5, 3.1, 4.2, -0.2, 5.1, 6.1, 7.1, 5.7};             // создаем массив из 10 элементов
// FillArray(arr, 0, 10);                          // заполняем массив случайными числами от [0,9]
Console.WriteLine($"Исходный массив из {array.Length} элементов");
Console.WriteLine(PrintArray(array));             // выводим массив на экран
double max = FindMax(array);                      // получаем максимальное значение в массиве  
double min = FindMin(array);                      // получаем минимальное значение в массиве
Console.WriteLine($"Разница между максимальным элементом {max} и минимальным элементом {min} равна {Math.Round(max - min, 3)}");   // выводим на экран результат