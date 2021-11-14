// 41. Выяснить являются ли три числа сторонами треугольника

// функция для проверки образуют три точки треугольник или нет
string TriangleOrNot(int x1, int y1, int x2, int y2, int x3, int y3) 
{   // если координаты трех точек различны и не совпадают, то это треугольник. Если координаты каких-либо двух точек совпадают, то это не треугольник, а прямая
    if (x1 == x2 && y1 == y2 || x1 == x3 && y1 == y3 || x2 == x3 && y2 == y3)   
        return $"Координаты введенных точек совпадают и не образуют треугольник";
    else
        return $"Введенные три точки образуют треугольник";
}

Console.Clear();
Console.WriteLine("Введите координаты точки A(x1,y1):");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B(x2,y2):");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки C(x3,y3):");
int x3 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());

// выводим на экран значение функции при заданных значениях координат
Console.WriteLine(TriangleOrNot(x1, y1, x2, y2, x3, y3)); 