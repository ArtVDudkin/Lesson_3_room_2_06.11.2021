// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
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

int SumPositive(int[] array)                            // функция для нахождения суммы положительных элементов массива
{
    int count = array.Length;
    int sumPos = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] > 0) sumPos += array[i];
    }
    return sumPos;
}

int SumNegative(int[] array)                            // функция для нахождения суммы положительных элементов массива
{
    int count = array.Length;
    int sumNeg = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
    }
    return sumNeg;
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, 0, 10);                          // заполняем массив случайными числами от 0 до 9
Console.WriteLine("Массив из 12 элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран
Console.WriteLine($"Сумма положительных элементов массива равна {SumPositive(arr)}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {SumNegative(arr)}");