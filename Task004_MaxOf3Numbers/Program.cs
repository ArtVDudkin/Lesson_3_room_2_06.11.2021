//  4. Найти максимальное из трех чисел

double findMax(double[] array)                                // Функция для нахождения максимального числа
{                                                             // по условиям задачи не понятно целое число или нет   
    double max = array[0];                                    // поэтому берем тип double 
    for (int index = 0; index < array.Length; index++)       
    {
        if(array[index] > max) max = array[index];            // ищем максимальное значение элемента в массиве
    }
    return max;                                               // возврщаем найденное максимальное значение
}

double[] array = new double[3];                               // массив, в котором будут храниться введенные числа

for (int index = 0; index < 3; index++)                       // Цикл для ввода сравниваемых чисел   
{
    Console.WriteLine($"Введите число {index +1}: ");         // Выводим на экран приглашение ко вводу
    array[index] = Convert.ToDouble(Console.ReadLine());      // Вводим числа для сравнения
}

double max = findMax(array);                                  // Вызываем функцию для нахождения максимального числа 
Console.WriteLine($"Максимум из трёх чисел равен {max}");     // Выводим на экран максимальное число  