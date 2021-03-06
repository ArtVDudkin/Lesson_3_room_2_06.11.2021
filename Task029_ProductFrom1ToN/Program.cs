// 29. Написать программу вычисления произведения чисел от 1 до N (это же факториал!) 

Console.WriteLine("Введите целое число N:");                // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип

int ProductFrom1ToN(int n)                                  // метод для расчета произведения чисел от 1 до N
{
    int prod = n;                                           // в переменную prod помещаем введенное число
    while (n-- > 1) prod *= n;                              // пока n > 1, умножаем текущее значение prod на следующее число (равное n-1)
    return prod;
}
// Выводим на экран результат, расчитанный с использованием метода
Console.WriteLine($"Произведение чисел от 1 до {number} = {ProductFrom1ToN(number)}"); 