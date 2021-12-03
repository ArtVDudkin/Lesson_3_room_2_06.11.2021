// 66. Показать натуральные числа от 1 до N, N задано

int ShowNextNumber(int i, int n)
{
    Console.Write($"{i} ");
    if (i == n) return n;
    return ShowNextNumber(i +1, n);;
}

Console.Clear();
ShowNextNumber(1, 10);
Console.WriteLine();