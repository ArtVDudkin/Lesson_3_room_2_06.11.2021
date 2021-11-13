// 25. Найти сумму чисел от 1 до А

Console.WriteLine("Введите целое число A:");                // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип

int SumFrom1ToA(int n)                                      // метод для расчета суммы чисел от 1 до А
{
    int sum = 0;
    for (int index = 1; index <= n; index++)                // для чисел от 1 до N
        sum += index;                                       // прибавляем к текущему значению следующее число
    return sum;
}
// Выводим на экран сумму чисел, расчитанную с использованием метода
Console.WriteLine($"Сумма чисел от 1 до {number} = {SumFrom1ToA(number)}"); 