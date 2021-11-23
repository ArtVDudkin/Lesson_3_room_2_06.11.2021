// 47. Написать программу копирования массива

char[] CreateArray(int count)                      // функция для создания массива символов чисел
{
    return new char[count];                      // размерности count, по умолчанию заполнен нулями
}

void FillArray(char[] arr, int minValue, int maxValue)     // функция для заполнения массива
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = (char)new Random().Next(minValue, maxValue);   // заполняем случайными символами от minValue до maxValue
    }
}

string PrintArray(char[] arr)                   // функция для вывода массива на экран
{
    int count = arr.Length;                   
    string res = String.Empty;                     // создаем пустую строку
    for (int i = 0; i < count; i++)
    {
        res += $"{arr[i]}  ";                    // формируем строку для вывода на экран
    }
    return res;
}

void CopyArray(char[] arrA, char[] arrB)          // функция для копирования массива А в В
{                         
    int count = arrA.Length;           
    for (int index = 0; index < count; index++)
        arrB[index] = arrA[index];      
}


Console.Clear();
char[] arrA = CreateArray(10);                    // создаем массив A из 10 элементов
FillArray(arrA, 48, 57);                          // заполняем массив случайными символами, 48-57 => числа от [0,9]
char[] arrB = CreateArray(arrA.Length);           // создаем массив B из такого же количества элементов, как и массив А
Console.WriteLine($"Исходный массив А");
Console.WriteLine(PrintArray(arrA));              // выводим массив A на экран
Console.WriteLine();
Console.WriteLine($"Исходный массив B");
Console.WriteLine(PrintArray(arrB));              // выводим исходный массив B на экран
CopyArray(arrA, arrB);                            // копируем массив А в массив В  
Console.WriteLine();
Console.WriteLine($"Скопированный массив B");
Console.WriteLine(PrintArray(arrB));              // выводим скопированный массив B на экран



// T[] CreateArray<T>(int count)                 // функция для создания массива произвольного типа из count элементов
// {
//     return new T[count];                      // размерности count, по умолчанию заполнен нулями
// }

// T ConvertToT<T>(int minValue, int maxValue)                 // функция для создания массива произвольного типа из count элементов
// {
//     return T = $"1"; //Convert.ToChar(new Random().Next(minValue, maxValue));                      // размерности count, по умолчанию заполнен нулями
// }

// void FillArray<T>(T[] arr, int minValue, int maxValue)     // функция для заполнения массива случайными символами от minValue до maxValue
// {
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         arr[i] = ConvertToT<char>(minValue, maxValue); // $"s"; //Convert.ToChar(new Random().Next(minValue, maxValue));  // заполняем случайными символами от minValue до maxValue
//     }
// }

// string PrintArray<T>(T[] arr)                   // функция для вывода массива на экран
// {
//     int count = arr.Length;                   
//     string res = String.Empty;                // создаем пустую строку
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{Convert.ToString(arr[i])} ";                  // формируем строку для вывода на экран
//     }
//     return res;
// }

// T[] CopyArray<T>(T[] arr)                       // функция для вывода массива на экран
// {
//     int length = arr.Length;
//     T[] result = new T[length];
//     for (int index = 0; index < length; index++)
//         result[index] = arr[index];
//     return result;
// }

// Console.Clear();

// int[] arrayA = CreateArray<int>(12);            // создаем целочисленный массив из 12 элементов
// FillArray<int>(arrayA, 48, 57);                 // заполняем массив случайными символами в диапазоне 48-57, это числами от [0,9]
// Console.WriteLine(PrintArray<int>(arrayA));     // выводим исходный массив А на экран

// int[] arrayB = CopyArray<int>(arrayA);          // копируем исходный массив А в массив В
// Console.WriteLine();
// Console.WriteLine(PrintArray<int>(arrayB));     // выводим скопированный массив В на экран