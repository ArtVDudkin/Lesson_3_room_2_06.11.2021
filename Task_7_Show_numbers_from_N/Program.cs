//  7. Показать числа от -N до N

void ShowMeNumbers(int number)                      // функция для вывода на экран чисел от -N до N
{
    int startNumber = -number;                      // начальное число равное -N
    int count = 2* number + 1;                      // определяем, сколько всего чисел от -N до N
    for (int index = 0; index < count; index++) 
    {
        Console.Write($"{startNumber} ");           // выводим текущее число на экран
        startNumber++;                              // получаем следующее число
    }
}

Console.WriteLine("Введите целое число N: ");       // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());   // Преобразуем введенное значение в целочисленный тип

ShowMeNumbers(number);                              // Вызываем метод для вывода на экран чисел от -N до N
Console.WriteLine();