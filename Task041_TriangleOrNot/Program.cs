// 41. Выяснить являются ли три числа сторонами треугольника

// функция для проверки могут ли три отрезка образовать треугольник или нет
string TriangleOrNot(int a, int b, int c) 
{   // Сумма длин двух любых сторон треугольника больше длины оставшейся стороны:
    if ( (a + b > c) && (a + c > b) && (b + c > a) )  
        return $"Введенные три отрезка могут образовать треугольник";
    else
        return $"Введенные три отрезка не могут образовать треугольник";
}

Console.Clear();
Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

// выводим на экран значение функции при заданных значениях координат
Console.WriteLine(TriangleOrNot(a, b, c)); 