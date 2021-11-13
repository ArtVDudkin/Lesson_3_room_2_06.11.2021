// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(0, 1000);          // заполняем элементы массива случайно значениями из [0,999]
}

int FindElement(int[] array, int borderL, int borderR)         // функция для замены элементов на противоположные
{
    int count = 0;                              // счетчик количества найденых элементов из отрезка
    for (int index = 0; index < array.Length; index++)
        if ( (array[index] >= borderL) && (array[index] <= borderR) )
            count++;                            // если надейно число из отрезка, то увеличиваем счетчик на 1
    return count;
}

int[] array = new int[123];                     // создаем массив из 123 элементов
int borderL = 10;                               // задаем отрезок для поиска значений в диапазоне значений [10,99]  
int borderR = 99;

Console.WriteLine("Исходный массив из 123 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]} ");
}
Console.WriteLine();       

if (FindElement(array, borderL, borderR) == 0)
    Console.WriteLine($"Элементы из отрезка [{borderL},{borderR}] в массиве не найдены");
else 
    Console.WriteLine($"Количество элементов в массиве из отрезка [{borderL},{borderR}] равно {FindElement(array, borderL, borderR)}");