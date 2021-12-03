// 68. Показать натуральные числа от M до N, N и M заданы

int ShowNextNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        if (m == n) return n;
        return ShowNextNumber(m +1, n);
    }
    else
    {
        Console.Write($"{m} ");
        if (m == n) return m;
        return ShowNextNumber(m -1, n);
    }
}

Console.Clear();
ShowNextNumber(20, 30);
Console.WriteLine();
