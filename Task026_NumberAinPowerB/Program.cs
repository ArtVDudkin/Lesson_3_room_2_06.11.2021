// 26. Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A:");             // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B:");           // Выводим на экран приглашение ко вводу
int power = Convert.ToInt32(Console.ReadLine());

int stepen(int number, int power)                  // метод для возведения числа А в степень В 
{
    int result = 1;                                // переменная, в которой будет расчитан результат
    while(power-- > 0) result *= number;           // в цикле пока степень >0, умножаем число само на себя и уменьшаем значение степени 
    return result;
}

// Выводим на экран результат, расчитанный с использованием метода
Console.WriteLine($"Число {number} в степени {power} = {stepen(number, power)}"); 