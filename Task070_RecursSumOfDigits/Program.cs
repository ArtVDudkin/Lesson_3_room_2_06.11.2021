// 70. Найти сумму цифр числа

int SumOfDigits(int number)
{
    number = Math.Abs(number);
    if (number / 10 == 0) return 1;
    else return number % 10 + SumOfDigits(number / 10);
}

Console.Clear();
Console.WriteLine(SumOfDigits(-123456));