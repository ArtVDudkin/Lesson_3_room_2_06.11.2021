//  5. Написать программу вычисления значения функции y=f(a)   y=sin^х(a)

double sinus(double arg, int power)       // метод для вычисления значения функции y=sin^х(a)
{
    double result = 1;
    double res = Math.Round(Math.Sin(arg * Math.PI / 180), 2);  // вычисляем, чему равно значение фунцкции y=sin(x) с точностью до 2 знаков после запятой
    for (int index = 1; index <= power; index++)
    {
        result = result * res;                            // возводим вычисленное значение фунцкции y=sin(x) в степень power
    }
    return result;                                        // возвращаем вычисленное значение функции y=sin^х(a)
}

Console.WriteLine("Введите фамилию сдающего:");
string username = Console.ReadLine();
int power = username.Length;
Console.WriteLine($"Введите аргумент функции sin^{power}(a), в градусах: ");   // запрос на ввод аргумента функции
double a = Convert.ToDouble(Console.ReadLine());                                 // считываем введенное значение

Console.WriteLine($"Значение функции sin^{power}({a}) равно: {sinus(a, power)}");