﻿// 28. Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");             // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());

int Razr(int n)                 // фунцкия для определения разрядности числа и нахождения суммы его разрядов
{
    n = Math.Abs(n);            // если введено отрицательное число, берем его модуль 
    int result = 0;             // количество найденных разрядов
    while(n != 0)               // пока результат деления числа на 10 не равен 0
    {        
        result += n % 10;       // увеличиваем число разрядов на 1
        n /= 10;                // и делим число на 10
    }
    return result;
}
// Выводим на экран результат, расчитанный с использованием метода
Console.WriteLine($"Сумма цифр в числе {number} равна {Razr(number)}");
// решение с использование встроенных библиотек С#
Console.WriteLine(
    $"Сумма цифр в числе {number} равна " + 
    number.ToString()           // переводим число типа int в тип string; 
    .ToCharArray()              // строку переводим в массив символов типа char
    .Select(e=>Convert.ToInt32(Convert.ToString(e)))  // в массиве символов каждый элемент типа char конвертируем в строку и далее в тип int   
    .Sum()                      // суммируем элементы массива; 
);