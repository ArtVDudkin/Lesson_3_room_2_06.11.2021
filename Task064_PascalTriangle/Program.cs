// 64. Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника
                                                                                                         
// 0 (a + b)^0                      1                                   0 степень + 1 = 1 элемент   + 2 пробела      0 0 1 0 0
// 1 (a + b)^1                    1   1                                 1 степень + 1 = 2 элемента  + 3 пробела        1 0 1 /
// 2 (a + b)^2                  1   2   1                               2 степень + 1 = 3 элемента  + 4 пробела             \ 1 = 1+0
// 3 (a + b)^3                1   3   3   1                             3 степень + 1 = 4 элемента  + 5 пробелов
// 4 (a + b)^4              1   4   6   4   1                           4 степень + 1 = 5 элементов + 6 пробелов
// 5 (a + b)^5           1   5   10   10   5   1                        5 степень + 1 = 6 элементов + 7 пробелов
// 6 (a + b)^6        1   6   15   20   15   6   1                      6 степень + 1 = 7 элементов + 8 пробелов
// 7 (a + b)^7      1   7   21   35   35   21   7   1                   7 степень + 1 = 8 элементов + 9 пробелов


int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void CreatePascalTriangle(int[,] array)                                 // метод для создания треугольника Паскаля
{
    int middle = array.GetLength(1) / 2;                                // ось симметрии массива
    array[0, middle] = 1;                                               // (a+b)^0 = 1 - начальный элемент (вершина) треугольника
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = middle - i; j <= middle + i; j++)                  //    1   1
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];    //      2
    }
}

int HowManyDigits(int n)                                                // метод для подсчета количества разрядов в числе
{
    int digits = 1;
    while (n / 10 != 0)
    {
        digits++;
        n /= 10;
    }
    return digits;
}

void ShowPascalTriangle(int[,] array)                                   // метод для вывода треугольника Паскаля на экран
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int maxElement = array[rows -1, cols / 2];                          // находим максимальный элемент в треугольнике, зная, что он находится в последней строке посередине
    if (maxElement == 0) maxElement = array[rows -1, cols / 2 -1];                                         
    int spaces = HowManyDigits(maxElement);// + 1;                         // количество символов на 1 столбец равно число разрядов максимального элемента в треугольнике + 1 пробел
    for (int i = 0; i < rows; i++)
    {
        string res = String.Empty;
        for (int j = 1; j < cols -1; j++)                               // крайние столбцы с нулями слева и справа не печатаем
        {
            if (array[i, j] == 0) res += $" ";
            else res += $"{array[i, j]}";
            for (int k = 0; k < spaces - HowManyDigits(array[i, j]); k++)
                res += $" ";                                            // добавляем необходимое количество пробелов в зависимости от разрядности текущего элемента
        }
        Console.WriteLine(res);
    }
}

Console.Clear();
Console.Write("Введите количество уровней треугольника Паскаля: ");
int m = Convert.ToInt32(Console.ReadLine()) + 1;                        // количество строк = m + 1, т.к. учитывается еще степень 0 для случая (a+b)^0 = 1
int n = 2*m + 1;                                                        // количество столбцов = кол-во элементов + 0 между ними и по краям массива
int[,] arrayNew = CreateArray(m,n);
CreatePascalTriangle(arrayNew);
ShowPascalTriangle(arrayNew);