// 72. Написать программу возведения числа А в целую стень B

int PowerAB(int number, int power)
{
    if (power == 0) return 1;
    else return number * PowerAB(number, power -1);
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return a* PowerRecMath(a, n -1);
}

Console.Clear();
Console.WriteLine(PowerAB(-2, 5));
Console.WriteLine(PowerRecMath(-2, 5));
