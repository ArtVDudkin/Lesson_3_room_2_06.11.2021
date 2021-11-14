// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] CreateArray(int count)                    // функция для создания массива
{
    return new int[count];                      // размерности count, по умолчанию заполнен нулями
}

void FillArray(int[] array, int minValue, int maxValue)     // функция для заполнения массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);   // заполняем случайными числами от minValue до maxValue
    }
}

string PrintArray(int[] array)                  // функция для вывода массива на экран
{
    int count = array.Length;                   
    string res = String.Empty;                  // создаем пустую строку
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";                  // формируем строку для вывода на экран
    }
    return res;
}

string FindElement(int[] array, int findMin, int findMax) // функция для замены элементов на противоположные
{
    int found = 0;                              // количество найденных значений (по умолчанию 0)
    int count = array.Length;
    string result = string.Empty;
    for (int index = 0; index < count; index++)
        if ( (array[index] >= findMin) && (array[index] <= findMax) )
            found++;                            // если найдено число из отрезка, то увеличиваем счетчик на 1
    
    if (found == 0)
        result = $"Элементы из отрезка [{findMin},{findMax}] в массиве не найдены";
    else 
        result = $"Количество элементов в массиве из отрезка [{findMin},{findMax}] равно {found}";
    return result;
}

Console.Clear();
int[] arr = CreateArray(123);                   // создаем массив из 123 элементов
FillArray(arr, 0, 1000);                        // заполняем массив случайными числами от 0 до 999
Console.WriteLine($"Массив из {arr.Length} элементов");
Console.WriteLine(PrintArray(arr));             // выводим исходный массив на экран
int findMin = 10;                               // значения для поиска элементов в диапазоне от 10
int findMax = 99;                               // до 99
Console.WriteLine(FindElement(arr, findMin, findMax));    // ищем элементы в массиве и выводим результат поиска на экран