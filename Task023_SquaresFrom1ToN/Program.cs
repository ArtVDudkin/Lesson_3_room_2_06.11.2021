// 23. Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите целое число N:");                // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип

int Squares(int n)                                          // Метод для расчета квадратов
{
    return n*n;
}

for (int index = 1; index <= number; index++)               // для чисел от 1 до N
{
    Console.WriteLine($"{index}^2 = {Squares(index)}");     // Выводим на экран таблицу квадратов, расчитанную с использованием метода
}