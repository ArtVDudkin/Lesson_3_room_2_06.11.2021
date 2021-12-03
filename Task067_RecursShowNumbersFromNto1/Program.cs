// 67. Показать натуральные числа от N до 1, N задано

int ShowNextNumber(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return 1;
    else return ShowNextNumber(n -1);
}

Console.Clear();
ShowNextNumber(10);
Console.WriteLine();