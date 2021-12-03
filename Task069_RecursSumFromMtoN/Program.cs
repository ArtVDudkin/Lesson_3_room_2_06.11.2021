// 69. Найти сумму элементов от M до N, N и M заданы

int SumFromMtoN(int m, int n)
{
    if (m < n)
    {
        if (m == n) return n;
        else return m + SumFromMtoN(m +1, n);
    }
    else
    {
        if (m == n) return n;
        return m + SumFromMtoN(m -1, n);
    }
}

Console.Clear();
Console.WriteLine(SumFromMtoN(-10, 10));