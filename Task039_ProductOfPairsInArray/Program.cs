// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

string ProductOfPairs(int[] array)              // функция для нахождения произведения пар элементов массива
{
    int count = array.Length;
    string result = string.Empty;               // контейнер для итогового сообщения
    for (int i = 0; i < count / 2; i++)         // от начала до половины от размерности массива
        result += $"Произведение пары {array[i]} х {array[count -1 - i]} = {array[i] * array[count -1 - i]} \n"; 
                                                // находим произведение пары и выполняем принудительный перенос на новую строку \n
    return result;
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, 0, 10);                          // заполняем массив случайными числами от [0,9]
Console.WriteLine($"Массив из {arr.Length} элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран
Console.WriteLine(ProductOfPairs(arr));         // выводим на экран результат