// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

string SumOfEven(int[] array)                   // функция для нахождения суммы элементов массива, стоящих на нечетных позициях
{
    int count = array.Length;
    string result = string.Empty;               // контейнер для итогового сообщения
    int sum = 0;                                // сумма значений элементов, стоящих на нечетных позициях
    for (int i = 1; i < count; i+=2)
        sum += array[i];                        // сумма значений элементов, стоящих на нечетных позициях
    result = $"Сумма элементов, стоящих на нечетных позициях, равна: {sum}";
    return result;
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, 0, 10);                          // заполняем массив случайными числами от [0,9]
Console.WriteLine($"Массив из {arr.Length} элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран
Console.WriteLine(SumOfEven(arr));              // выводим на экран результат