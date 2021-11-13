// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Введите целое число N:");                // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип

int Kubes(int n)                                          // Метод для расчета кубов
{
    return Convert.ToInt32(Math.Pow(n, 3));
}

for (int index = 1; index <= number; index++)               // для чисел от 1 до N
{
    Console.WriteLine($"{index}^3 = {Kubes(index)}");     // Выводим на экран таблицу кубов, расчитанную с использованием метода
}