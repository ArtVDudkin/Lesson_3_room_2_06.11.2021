// 22. Найти расстояние между точками в пространстве 2D/3D

// функция для определения расстояния между точками в 2D пространстве
double Distance2D(int x1, int y1, int x2, int y2) 
{      // расстояние между точками в 2D равно корень из ( (х2-х1)^2 + (y2-y1)^2 )
    return Math.Round( Math.Sqrt( Math.Pow( (x2 - x1), 2) + Math.Pow( (y2 - y1), 2) ) , 2);
}

// функция для определения расстояния между точками в 3D пространстве
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2) 
{      // расстояние между точками в 3D равно корень из ( (х2-х1)^2 + (y2-y1)^2 + (z2-z1)^2 )
    return Math.Round( Math.Sqrt( Math.Pow( (x2 - x1), 2) + Math.Pow( (y2 - y1), 2) + Math.Pow( (z2 - z1), 2) ) , 2);
}

Console.Clear();
Console.WriteLine("Выберите пространство, в котором будем работать: 2 - для 2D-пространства, 3 - для 3D-пространства:");
int dimension = Convert.ToInt32(Console.ReadLine());
while ( (dimension < 2) || (dimension > 3) )              // Проверяем, является корректно ли введено значение 
{
    Console.WriteLine("Введено некорректное значение. Выберите 2 - для 2D-пространства, 3 - для 3D-пространства");
    dimension = Convert.ToInt32(Console.ReadLine());
}
if (dimension == 2)     // код для работы с точками в 2D-пространстве
{
    //
    Console.WriteLine("Введите координаты точки A(x1,y1):");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B(x2,y2):");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());

    // выводим на экран значение функции при заданных значениях координат Х и У
    Console.WriteLine($"Расстояние между точками А({x1},{y1}) и В({x2},{y2}) равно {Distance2D(x1, y1, x2, y2)}"); 
}

if (dimension == 3)     // код для работы с точками в 3D-пространстве
{
    Console.WriteLine("Введите координаты точки A(x1,y1,z1):");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B(x2,y2,z2):");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    // выводим на экран значение функции при заданных значениях координат Х, У, Z
    Console.WriteLine($"Расстояние между точками А({x1},{y1},{z1}) и В({x2},{y2},{z2}) равно {Distance3D(x1, y1, z1, x2, y2, z2)}"); 
}