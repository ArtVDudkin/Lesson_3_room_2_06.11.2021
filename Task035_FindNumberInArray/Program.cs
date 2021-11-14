// 35. Определить, присутствует ли в заданном массиве, некоторое число

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

string FindElement(int[] array, int findNumber) // функция для замены элементов на противоположные
{
    int pos = -1;                               // маркер, найдено ли искомое число
    int count = array.Length;
    string res = string.Empty;
    for (int index = 0; index < count; index++)
        if (array[index] == findNumber) 
        {
            pos = index;                        // если искомое число найдено, запоминаем его индекс
            break;                              // и останавливаем дальнейший поиск
        }
    if (pos != -1)                              // если элемент найден, то выводим сообщение
        res = $"Число {findNumber} присутствует в массиве";
    else                                        // если элемент не найден, то выводим сообщение
        res = $"Число {findNumber} отсутствует в массиве";
    return res;
}

Console.Clear();
int[] arr = CreateArray(12);                    // создаем массив из 12 элементов
FillArray(arr, -10, 10);                        // заполняем массив случайными числами от 0 до 9
Console.WriteLine($"Массив из {arr.Length} элементов");
Console.WriteLine(PrintArray(arr));             // выводим исходный массив на экран
Console.WriteLine("Введите число для поиска в массиве");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(FindElement(arr, number));    // ищем элемент в массиве и выводим результат поиска на экран