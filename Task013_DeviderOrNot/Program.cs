// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

bool DeviderOrNot(int number1, int number2)            // функция для проверки, является ли число 2 делителем числа 1
{
    return (number1 % number2 == 0);                   // если число 1 делится на число 2 без остатка, возвращаем истину
}

Console.WriteLine("Введите первое число:");            // Выводим на экран приглашение ко вводу
int number1 = Convert.ToInt32(Console.ReadLine());     // Преобразуем введенное значение в целочисленный тип
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (DeviderOrNot(number1, number2) == true)             // Вызываем функцию проверки чисел
    Console.WriteLine($"Число {number1} кратно числу {number2}");    // если истина, выводим это сообщение
else 
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток равен {number1 % number2}"); // если ложь, выводим это сообщение