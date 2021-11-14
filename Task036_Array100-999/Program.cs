// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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

string EvenOdd(int[] array, int even)           // функция для нахождения количества четных/нечетных элементов массива
{
    int count = array.Length;
    string result = string.Empty;               // контейнер для итогового сообщения
    int kolvo = 0;                              // количество найденных элементов
    for (int i = 0; i < count; i++)
    {
        if ((even == 1) && (array[i] % 2 != 0)) kolvo++;    // если параметр even =1, ищем количество нечетных элементов
        if ((even == 2) && (array[i] % 2 == 0)) kolvo++;    // если параметр even =2, ищем количество четных элементов
    }
    if (even == 1) result = $"Количество нечетных элементов в массиве: {kolvo}";
    if (even == 2) result = $"Количество четных элементов в массиве: {kolvo}";
    return result;
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, 100, 1000);                      // заполняем массив случайными числами от [100, 999]
Console.WriteLine($"Массив из {arr.Length} элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран
Console.WriteLine("Введите число для параметр: 1 - для поиска нечетных элементов, 2 - для поиска четных элементов в массиве");
int param = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(EvenOdd(arr, param));             // Указать параметр 1 - нечетные, 2 - четные