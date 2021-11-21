// 45. Показать числа Фибоначчи
// 1 1 2 3 5 8 13 21 34 55 89

int GenNextFibo(int firstBefore, int secondBefore)      // функция для нахождения следующего числа в последовательности Фибоначчи из двух предыдущих
{
    return secondBefore + firstBefore;
}

void ShowAllFibo(int limit)
{
    int firstFibo = 0;                                  // первое число в последовательности Фибоначчи равно 0
    int secondFibo = 1;                                 // второе число в последовательности Фибоначчи равно 1
    Console.WriteLine($"Числа Фибоначчи от 1 до {limit}:");
    Console.Write($"{firstFibo} {secondFibo} ");
    int nextFibo = 0;                                   // переменная для нахождения следующего числа в последовательности Фибоначчи
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
int number = Convert.ToInt32(Console.ReadLine());
ShowAllFibo(number);
Console.WriteLine();