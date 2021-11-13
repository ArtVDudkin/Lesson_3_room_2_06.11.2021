// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите целое число N:");                // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип

int Cubes(int n)                                          // Метод для расчета кубов
{
    return n*n*n;
}

for (int index = 1; index <= number; index++)               // для чисел от 1 до N
{
    if (Cubes(index) % 10 % 2 == 0)
        Console.WriteLine($"{index}^3 = {Cubes(index)}");   // Выводим на экран кубы чисел, заканчивающихся на четную цифру
}