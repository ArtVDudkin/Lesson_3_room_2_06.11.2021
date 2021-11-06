//  8. Показать четные числа от 1 до N

void ShowMeOrdinaryNumbers(int number)              // функция для вывода на экран чётных чисел от 1 до N
{
    int startNumber = 1;                            // начальное число равное 1
    for (int index = 1; index <= number; index++) 
    {
        if (startNumber % 2 == 0)                    // проверяем, если число чётное, то
            Console.Write($"{startNumber} ");       // выводим его на экран
        startNumber++;                              // переходим к следующему числу
    }
}

Console.WriteLine("Введите целое число N: ");       // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());   // Преобразуем введенное значение в целочисленный тип

Console.WriteLine($"Чётные числа от 1 до {number}: ");
ShowMeOrdinaryNumbers(number);                      // Вызываем метод для вывода на экран чётных чисел от 1 до N
Console.WriteLine();