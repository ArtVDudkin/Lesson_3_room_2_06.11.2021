// 45. Показать числа Фибоначчи
// 1 1 2 3 5 8 13 21 34 55 89

double GenNextFibo(double firstBefore, double secondBefore)      // функция для нахождения следующего числа в последовательности Фибоначчи из двух предыдущих
{
    return secondBefore + firstBefore;
}

void ShowAllFibo(double limit)
{
    double firstFibo = 0;                                  // первое число в последовательности Фибоначчи равно 0
    double secondFibo = 1;                                 // второе число в последовательности Фибоначчи равно 1
    Console.WriteLine($"Числа Фибоначчи от 1 до {limit}:");
    Console.Write($"{firstFibo} {secondFibo} ");
    double nextFibo = 0;                                   // переменная для нахождения следующего числа в последовательности Фибоначчи
    while ( (firstFibo + secondFibo) < limit)
    {
        nextFibo = GenNextFibo(firstFibo, secondFibo);  // генерируем следующее число в последовательности Фибоначчи из двух предыдущих
        Console.Write($"{nextFibo} ");
        firstFibo = secondFibo;                         // обновляем значения "предыдущих" чисел в последовательности Фибоначчи
        secondFibo = nextFibo;                          // для расчета следующего числа
    } 
}

Console.Clear();                                        // очистка экрана
Console.WriteLine($"Введите число, до которого необходимо показать числа Фибоначчи:");
double number = Convert.ToDouble(Console.ReadLine());
ShowAllFibo(number);
Console.WriteLine();

// в районе 40х чисел в последовательности Фибоначчи метод рекурсия начинает жрать ресурсы на вычисления
// double Fibonacci(double n)
// {
//     if ( (n == 1) || (n == 2) ) return 1;
//     else return Fibonacci(n -1) + Fibonacci(n -2); 
// }
// Console.WriteLine(Fibonacci(40)); 