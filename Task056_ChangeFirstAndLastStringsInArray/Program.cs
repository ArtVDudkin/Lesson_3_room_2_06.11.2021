// 56. Написать программу, которая обменивает элементы первой строки и последней строки

char[,] CreateArray(int m, int n)
{
    return new char [m,n];
}

void FillArray(char[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = (char)new Random().Next(minValue, maxValue);
        }
    }
}
// метод для замены элементов первой строки и последней строки
void ChangeStringsInArray(char[,] array, int firstString, int lastString)
{
    char temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[firstString, j];
        array[firstString, j] = array[lastString, j];
        array[lastString, j] = temp;
    }
}

void PrintArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 4;
int n = 6;
char[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew, 65, 90);           // вызываем метод для заполнения массива символами A..Z
PrintArray(arrayNew);
Console.WriteLine();
ChangeStringsInArray(arrayNew, 0, 3);  // вызываем метод для замены элементов первой строки и последней строки
PrintArray(arrayNew);