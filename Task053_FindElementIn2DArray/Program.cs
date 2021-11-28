// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
}

(int m, int n) FindElementInArray(int[,] array, int findValue)
{
    int m = -1;                         // если число не найдено, вернется (-1,-1)
    int n = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == findValue) 
            {                           // если заданное пользователем число найдено, то
                m = i;                  // запоминаем его индексы
                n = j;
                break;                  // останавливаем внутренний цикл
            }
        }
        if (m != -1 && n != -1) break;  // если число найдено, останавливаем внешний цикл
    }                                   // если используем break, то находим индексы первого вхождения
    return (m, n);                      // если не использовать break, то найдется последнее вхождение числа
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            System.Console.Write($"{array[i, j],2} ");
        }
    System.Console.WriteLine();
    }
}

int m = 4;
int n = 5;
int[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew, -5, 6);                             // вызываем метод для заполнения массива числами [-5, 5]
PrintArray(arrayNew);
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElementInArray(arrayNew, findNumber));