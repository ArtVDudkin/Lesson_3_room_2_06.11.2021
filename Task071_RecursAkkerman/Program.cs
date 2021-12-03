// 71. Написать программу вычисления функции Аккермана

//          n + 1                   , при m = 0
// A(m,n) = A(m -1, 1)              , при m > 0, n = 0 
//          A(m -1, A(m, n -1))     , при m > 0, n > 0

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.WriteLine(Akkerman(0, 0)); // = 1
Console.WriteLine(Akkerman(1, 0)); // = 2
Console.WriteLine(Akkerman(3, 0)); // = 5
Console.WriteLine(Akkerman(3, 2)); // = 29