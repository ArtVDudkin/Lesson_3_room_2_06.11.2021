//  2. Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число:");            // Выводим на экран приглашение ко вводу
int number1 = Convert.ToInt32(Console.ReadLine());     // Преобразуем введенное значение в целочисленный тип
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)                                 // Если первое число больше
    Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");   // то выводим это сообщение
else 
    Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");   // инача выводим это сообщение