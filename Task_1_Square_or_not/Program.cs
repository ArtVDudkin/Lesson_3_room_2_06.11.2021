//  1. По двум заданным числам проверять является ли первое квадратом второго

bool SquareOrNot(int number1, int number2)            // функция для проверки, является ли число 1 квадратом числа 2
{
    if (number1 == number2*number2) return true;      // если является, возвращаем истину
    else return false;                                // если не является, возвращаем ложь
}

Console.WriteLine("Введите первое число:");            // Выводим на экран приглашение ко вводу
int number1 = Convert.ToInt32(Console.ReadLine());     // Преобразуем введенное значение в целочисленный тип
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (SquareOrNot(number1, number2) == true)             // Вызываем функцию проверки чисел
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");    // если истина, выводим это сообщение
else 
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}"); // если ложь, выводим это сообщение