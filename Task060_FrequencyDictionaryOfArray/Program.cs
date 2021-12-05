// 60. Составить частотный словарь элементов двумерного массива

char[,] CreateArray(int m, int n)
{
    return new char[m, n];
}

void FillArray(char[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (char)new Random().Next(minValue, maxValue + 1);     //  Guid.NewGuid().ToString() - задать случайную строку
        }
    }
}

string[,] MakeFrequencyDictionary(char[,] array)                // метод для создания частотного словаря
{
    string[,] result = new string[2, array.GetLength(0) * array.GetLength(1)];
    int dictIndex = 0;                                          // текущий свободный индекс для создания нового элемента в словаре
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int matchIndex = -1;                                // индекс для запоминания индекса элемента в словаре, если такой элемент найден 
            for (int k = 0; k < result.GetLength(1); k++)
                if (Convert.ToString(array[i, j]) == result[0, k])
                    matchIndex = k;
            if (matchIndex == -1)                               // если элемент в словаре не найден, то добавляем его в словарь
            {
                result[0, dictIndex] = Convert.ToString(array[i, j]);
                result[1, dictIndex] = $"1";
                dictIndex++;
            }
            else                                                // если элемент в словаре уже есть, увеличиваем количество этого элемента на 1
                result[1, matchIndex] = $"{Convert.ToInt32(result[1, matchIndex]) + 1}";
        }
    }
    return result;
}

string[,] SortDictionary(string[,] array)                       // метод для сортировки полученного словаря для более удобного отображения
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = j; k < array.GetLength(1); k++)
        {
            if (array[0, k] != default)
            {
                string tempName = array[0, j];
                string tempValue = array[1, j];
                if (Convert.ToChar(array[0, k]) < Convert.ToChar(array[0, j]))
                {
                    tempName = array[0, j];
                    tempValue = array[1, j];
                    array[0, j] = array[0, k];
                    array[1, j] = array[1, k];
                    array[0, k] = tempName;
                    array[1, k] = tempValue;
                }
            }
        }
    }
    return array;
}

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintDictionary(string[,] dictionary)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < dictionary.GetLength(1); j++)
        {
            Console.Write($"{dictionary[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 6;
char[,] arrayNew = CreateArray(m, n);
FillArray(arrayNew, 65, 90);                    // 48-57 цифры 0..9, 65-90 буквы A..Z
PrintArray(arrayNew);
Console.WriteLine();
string[,] dictionary = new string[2, m * n];    // максимальное количество столбцов равно m * n, если все элементы разные и не повторяются
dictionary = MakeFrequencyDictionary(arrayNew);

// PrintDictionary(dictionary);
// Console.WriteLine();
dictionary = SortDictionary(dictionary);
PrintDictionary(dictionary);