// 72. Написать программу возведения числа А в целую стень B

int PowerAB(int number, int power)
{
    if (power == 0) return 1;
    else return number * PowerAB(number, power -1);
}

Console.Clear();
Console.WriteLine(PowerAB(-2, 5));