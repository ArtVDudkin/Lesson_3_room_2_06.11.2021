// 43. Написать программу преобразования десятичного числа в двоичное

// функция конвертирования числа из десятичной системы в двоичную или другую baseX
string DecConverter(int number10, int baseX) 
{                       // 37          2                      1 0 1 0 0 1 ->reverse =          100101
    int ostatok = number10;
    string signs = $"0123456789ABCDEF"; 
    string result = string.Empty;
    while (number10 != 0)
    {
        ostatok = number10;                     // 37               18              9               4               2               1
        number10 = number10 / baseX;            // 37/2     = 18    18/2     = 9    9/2     = 4     4/2     = 2     2/2     = 1     1/2 = 0
        ostatok = ostatok - number10 * baseX;   // 37 - 18*2 = 1    18 - 9*2 = 0    9 - 4*2 = 1     4 - 2*2 = 0     2 - 2*1 = 0     1 - 0*2 = 1    
        result = signs[ostatok] + result;       // 1+''             0+1             1+01            0+101           0+0101          1+00101
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число в десятичной системе счисления:");
int number10 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите систему счисления, в которую нужно преобразовать число (не больше 16):");
int baseX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{DecConverter(number10, baseX)}");