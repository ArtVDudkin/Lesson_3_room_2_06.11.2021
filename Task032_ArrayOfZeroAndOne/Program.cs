// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

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

Console.Clear();
int[] arr = CreateArray(8);                     // создаем массив из 8 элементов
FillArray(arr, 0, 2);                           // заполняем массив случайными числами [0, 1]
Console.WriteLine("Массив из 8 элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран