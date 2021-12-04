// 68. Показать натуральные числа от M до N, N и M заданы

string ShowNextNumber(int m, int n)
{
    if (m == n) return $"{m}";
    if (m < n)
    {
        return $"{m} {ShowNextNumber(m +1, n)}";
    }
    else
    {
        return $"{m} {ShowNextNumber(m -1, n)}";
    }
}

Console.Clear();
Console.WriteLine(ShowNextNumber(20, 30));
Console.WriteLine(ShowNextNumber(20, 10));