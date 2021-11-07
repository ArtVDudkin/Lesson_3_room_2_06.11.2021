﻿// 15. Дано число. Проверить кратно ли оно 7 и 23

bool DeviderOf7and23(int number)          // функция для проверки, является ли введенное число кратным 7 и 23
{
    return (number % 7 == 0) && (number % 23 == 0);          // возвращаем истину, если число делится на 7 и на 23 без остатка
}

Console.WriteLine("Введите целое число: ");                  // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());            // Преобразуем введенное значение в целочисленный тип
if (DeviderOf7and23(number))                                 // Вызываем функцию проверки числа на четность
    Console.WriteLine($"Число {number} кратно 7 и 23");      // если истина, выводим это сообщение
else 
    Console.WriteLine($"Число {number} не кратно 7 и 23");   // если ложь, выводим это сообщение