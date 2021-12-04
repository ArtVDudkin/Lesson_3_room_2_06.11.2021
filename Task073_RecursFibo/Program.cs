// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//     Первые два элемента последовательности задаются пользователем

string Sequence(int f1, int f2, int n)
{
    if (n == 0) return String.Empty;
    return $"{f1} {Sequence(f2, f2 + f1, n -1)} ";
}

Console.Clear();
Console.WriteLine("Введите первый элемент последовательности");
int f1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй элемент последовательности");
int f2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sequence(f1,f2, 10)); 