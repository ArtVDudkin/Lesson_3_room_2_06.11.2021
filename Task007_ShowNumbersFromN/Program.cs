//  7. Показать числа от -N до N

string ShowMeNumbers(int number)                      // функция для вывода на экран чисел от -N до N
{                     
    return Convert.ToString(number) + " ";            // возвращаем текущее значение number в текстовом виде;                                    // в
}

Console.WriteLine("Введите целое число N: ");         // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());     // Преобразуем введенное значение в целочисленный тип
for (int index = -number; index <= number; index++)   // в цикле от -N до N 
    {
        Console.Write(ShowMeNumbers(index));          // выводим текущее число на экран, вызывая метод для вывода чисел от -N до N
    }
Console.WriteLine();