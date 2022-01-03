// 75. Есть два массива info и data.
    // Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
    // Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
    // Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
    // Пример:
    // входные данные:
    // data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
    // info = {2, 3, 3, 1 }

    // выходные данные:
    // 1, 7, 0, 1
    // Какие ошибки могут возникнуть при обработке наборов данных?

    // Ошибки: 
    // - если в массиве data окажется меньше элементов, чем сумма элементов массива info, то будет вылет за пределы массива    
    // - если в массивах будут отрицательные числа, то программа будет работать некорректно или не будет работать вовсе
    // - Если в массиве data будут другие цифры, кроме 0 и 1, расчет будет неправильный 

int[] CreateArray(int size)
{
    return new int[size];
}

bool DataError(int[] data)
{
    bool flag = false;
    for (int i = 0; i < data.Length; i++)
        if ( (data[i] != 0) && (data[i] != 1) )
            flag = true;
    return flag;   
}

int SumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    return sum;
}

// метод для заполнения массива десятичных представлений чисел массива data с учётом информации из массива info
int[] BinaryToDec(int[] data, int[] info)
{
    int[] res = CreateArray(info.Length);
    int indexPos = 0;                      // индекс элемента в массиве data, от которого идет расчет следующего 10чного представления
    for (int i = 0; i < info.Length; i++)
    {    
        int k = 0;                         // текущий индекс для расчета степени числа 2
        for (int j = indexPos; j < (info[i] + indexPos); j++)
        {
            res[i] += data[j]*(int)Math.Pow(2, info[i] -1 - k);
            k++;
        }
        indexPos += info[i];
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1)
            Console.Write(", ");
        else 
            Console.WriteLine();
    }
}

Console.Clear();
int[] data = new int[] {0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0};
int[] info = new int[] {2, 3, 3, 1, 4};

if (DataError(data) )
    Console.WriteLine("Некорректно введены значения в массиве data!");
else if (SumOfElements(info) != data.Length)
    Console.WriteLine("Ошибка ввода данных. В массиве data указано недостаточно значений!");
else
    {
        int[] res = BinaryToDec(data, info);
        PrintArray(res);
    }