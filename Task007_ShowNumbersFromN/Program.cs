//  7. Показать числа от -N до N

void ShowMeNumbers(int number)                      // функция для вывода на экран чисел от -N до N
{                     
    for (int index = -number; index <= number; index++)  // в цикле от -N до N 
    {
        Console.Write($"{index} ");                 // выводим текущее число на экран
    }
}

Console.WriteLine("Введите целое число N: ");       // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());   // Преобразуем введенное значение в целочисленный тип

ShowMeNumbers(number);                              // Вызываем метод для вывода на экран чисел от -N до N
Console.WriteLine();