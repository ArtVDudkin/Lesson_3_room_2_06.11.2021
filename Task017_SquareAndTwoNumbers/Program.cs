//  17. По двум заданным числам проверять является ли одно квадратом другого

int SquareOrNot(double number1, double number2)          // функция для проверки, является ли одно число квадратом другого
{
    if (number1 == number2*number2) return 1;            // если число 1 является квадратом числа 2, возвращаем 1
    else if (number2 == number1*number1) return 2;       // если число 2 является квадратом числа 1, возвращаем 2
    else return 0;                                       // если числа не являются квадратом друг друга, возвращаем 0
}

Console.WriteLine("Введите первое число:");              // Выводим на экран приглашение ко вводу
double number1 = Convert.ToDouble(Console.ReadLine());   // Преобразуем введенное значение в целочисленный тип
Console.WriteLine("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
if (SquareOrNot(number1, number2) == 1)                  // Вызываем функцию проверки чисел и проверяем значение, которое вернул метод
    Console.WriteLine($"Число {number1} является квадратом числа {number2}"); // если метод вернул 1, выводим это сообщение
if (SquareOrNot(number1, number2) == 2) 
    Console.WriteLine($"Число {number2} является квадратом числа {number1}"); // если метод вернул 2, выводим это сообщение
if (SquareOrNot(number1, number2) == 0)                                       // если метод вернул 0, выводим это сообщение  
    Console.WriteLine($"Число {number1} не является квадратом числа {number2} и число {number2} не является квадратом числа {number1}"); // если ложь, выводим это сообщение 