// 66. Показать натуральные числа от 1 до N, N задано

string ShowNextNumber(int n)
{
    if (n == 1) return $"1";
    else return $"{n} {ShowNextNumber(n -1)}";
}

Console.Clear();
Console.WriteLine(ShowNextNumber(10));