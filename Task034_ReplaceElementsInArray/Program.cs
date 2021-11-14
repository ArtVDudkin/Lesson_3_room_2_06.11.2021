// 34. Написать программу замены элементов массива на противоположные

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

void ReplaceArray(int[] array)                            // функция для нахождения суммы положительных элементов массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = -1*array[i];
    }
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, -10, 10);                          // заполняем массив случайными числами от 0 до 9
Console.WriteLine("Массив из 12 элементов");
Console.WriteLine(PrintArray(arr));             // выводим исходный массив на экран
ReplaceArray(arr);                              // заменяем элементы в массиве на противоположные
Console.WriteLine("Массив с элементами, замененными на противоположные");
Console.WriteLine(PrintArray(arr));             // выводим измененный массив на экран