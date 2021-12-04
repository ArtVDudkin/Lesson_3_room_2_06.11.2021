// 67. Показать натуральные числа от N до 1, N задано

string ShowNextNumber(int n)
{
    if (n == 1) return $"1";
    else return $"{ShowNextNumber(n -1)} {n}";
}

Console.Clear();
Console.WriteLine(ShowNextNumber(10));