// 65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 

int[,] CreateArray(int m, int n)
{
    return new int [m,n];
}

void FillArray(int[,] array)
{
    int counter = 1;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int maxValue = row * col;
    int up = 0;
    int down = row -1;
    int left = 0;
    int right = col -1;
    while (counter < maxValue)
    {   
        for (int j = left; j <= right; j++)
            if (counter <= maxValue) 
                array[up,j] = counter++;
        up++;
        for (int i = up; i <= down; i++)
            if (counter <= maxValue) 
                array[i,right] = counter++;
        right--;     
        for (int j = right; j >= left; j--)
            if (counter <= maxValue) 
                array[down,j] = counter++;
        down--;
        for (int i = down; i >= up; i--)
            if (counter <= maxValue) 
                array[i,left] = counter++;   
        left++;
    }
}

void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            Console.Write($"{array[i, j],3}   ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = 8;      // для проверки на глюки (m = 8, n = 5) (m = 7, n = 8)
int n = 5;
int[,] arrayNew = CreateArray(m,n);
FillArray(arrayNew);
PrintArrayInt(arrayNew);