// 35. Определить, присутствует ли в заданном массиве, некоторое число

int FillArray()                                 // функция для заполнения массива
{
    return new Random().Next(-9, 10);           // заполняем элементы массива случайно значениями из [-9,9]
}

int FindElement(int[] array, int findN)         // функция для замены элементов на противоположные
{
    int pos = -1;                               // маркер, найдено ли искомое число
    for (int index = 0; index < array.Length; index++)
        if (array[index] == findN) 
        {
            pos = index;                        // если искомое число найдено, запоминаем его индекс
            break;                              // и останавливаем дальнейший поиск
        }
    return pos;                                 // возвращаем индекс искомого числа в массиве
}

int[] array = new int[12];                      // создаем массив из 12 элементов

Console.WriteLine("Исходный массив из 12 элементов");
for (int index = 0; index < array.Length; index++)
{
    array[index] = FillArray();                 // заполняем элементы массива случайными числами
    Console.Write($"{array[index]} ");
}
Console.WriteLine();

Console.WriteLine("Введите число для поиска в массиве");
int number = Convert.ToInt32(Console.ReadLine());           

if (FindElement(array, number) != -1)           // если функция вернула значение, отличное от -1, то выводим сообщение, что элемент найден
    Console.WriteLine($"Число {number} присутствует в массиве");
else                                            // если функция вернула -1, то выводим сообщение об отсутсвии искомого числа
    Console.WriteLine($"Число {number} отсутствует в массиве");