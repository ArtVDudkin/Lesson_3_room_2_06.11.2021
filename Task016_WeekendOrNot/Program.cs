﻿// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

string dayweek (int number)
{
    // создаем массив с названиями дней недели
    string[] dayweek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    return dayweek[number -1]; // возвращаем название дня недели по его номеру, учитывая что дни недели начинаются с 1
                               // а элементы в массиве нумеруются начиная с 0
}

Console.WriteLine("Введите номер дня недели от 1 до 7:");    // Выводим на экран приглашение ко вводу
int day = Convert.ToInt32(Console.ReadLine());               // Преобразуем введенное значение в целочисленный тип
while ( (day < 1) || (day > 7) )
{
    Console.WriteLine("Введено некорректное значение. Введите номер дня недели от 1 до 7!");
    day = Convert.ToInt32(Console.ReadLine());
}

if ( (day == 6) || (day == 7) ) 
    Console.WriteLine($"{dayweek(day)} это выходной день"); // Выводим на экран, если день выходной    
else 
    Console.WriteLine($"{dayweek(day)} это рабочий день");  // Выводим на экран, если день рабочий    
