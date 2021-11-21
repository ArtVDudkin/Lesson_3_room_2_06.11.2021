// 41. Выяснить являются ли три числа сторонами треугольника

// функция для проверки могут ли три отрезка образовать треугольник или нет
bool TriangleOrNot(double a, double b, double c) 
{   // Сумма длин двух любых сторон треугольника больше длины оставшейся стороны:
        return ( (a + b > c) && (a + c > b) && (b + c > a) );
}

Console.Clear();
Console.WriteLine("Введите три числа:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

// выводим на экран значение функции при заданных значениях координат
Console.WriteLine(TriangleOrNot(a, b, c)); 