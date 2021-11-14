// 31. Задать массив из 8 элементов и вывести их на экран

char[] CreateArray(int count)                    // функция для создания массива
{
    return new char[count];                      // размерности count, по умолчанию заполнен пустыми символами
}

void FillArray(char[] array, int minValue, int maxValue)     // функция для заполнения массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToChar(new Random().Next(minValue, maxValue));  // заполняем случайными символами от minValue до maxValue
    }
}

string PrintArray(char[] array)                  // функция для вывода массива на экран
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
char[] arr = CreateArray(8);                    // создаем массив из 8 элементов
FillArray(arr, 65, 90);                         // заполняем массив случайными символами с индексами от A до Z
Console.WriteLine("Массив из 8 элементов");
Console.WriteLine(PrintArray(arr));             // выводим массив на экран