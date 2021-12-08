// 46. Написать программу масштабирования фигуры
// координаты вводим в формате (N,N) (N,N) (N,N) (N,N)

double[,] CreateArray(int row, int col)             // функция для создания массива
{
    return new double[2, col];                      // размерности 2 x col, по умолчанию заполнен нулями
}

string TextFormatter(string text)                   // метод для форматирования введенный строки с координатами
{
    string result = String.Empty;
    int length = text.Length;
    if (text[0] == ')')                     // если строка начинается с )
    {
        text = text.Substring(1);           // то удаляем скобку
        length--;                           // и уменьшаем расчитанную длину строки на 1
    }
    if (text[length -1] == ')')             // если строка не заканчивается ")", то добавляем ее 
    {   
        text += ')';                        // это нужно для корректной работы метода считывания координат
        length++;                           // и увеличиваем расчитанную длину строки на 1
    }
     if (text[length -1] == '(')            // если строка заканчивается "(", то удаляем ее 
    {   
        text = text.Substring(0, length -1);// это нужно для корректной работы метода считывания координат
        length--;                           // и увеличиваем расчитанную длину строки на 1
    }  
    for (int i = 0; i < length; i++)
    {                                       // если текущий элемент пробел и следующий элемент тоже пробел, то не копируем его
        if (text[i] == ' ') result += $""; 
        else if ( (i != (length -1)) && (text[i] == '(') && (text[i +1] == '(') ) result += $"";
        else if ( (i != (length -1)) && (text[i] == ')') && (text[i +1] == ')') ) result += $"";
        else if ( (i != (length -1)) && (text[i] == ',') && (text[i +1] == ',') ) result += $"";
        else result += $"{text[i]}";
    }
    // Console.WriteLine(result);
    return result;
}

int PointsCounter(string coord)                     // метод для определения, сколько точек (N,N) введено
{
    int counter = 0;
    int countComma = 0;
    int countOpen = 0;
    int countClose = 0;
    for (int i = 0; i < coord.Length; i++)
    {
        if (coord[i] == ',') countComma++;
        if (coord[i] == '(') countOpen++;
        if (coord[i] == ')') countClose++;
    }
    if ( (countOpen == countClose) && (countOpen == countComma) )
        counter = countOpen;
    return counter;
}

double[,] CoordReader(string coord)                 // метод для получения координат из введенной строки
{
    int counter = PointsCounter(coord);
    double [,] resultCoord = CreateArray(2, counter);
    if (counter == 0) 
    {
        Console.WriteLine("Ошибка ввода! Проверьте правильность введения данных!");

    }
    else 
    {
        for (int i = 0; i < counter; i++)   
        {
            int posComma = 0;
            string temp = string.Empty;
            while (coord[posComma] != ',' )
                posComma++;
            temp = coord.Substring(1, posComma - 1);
            resultCoord[0,i] = Convert.ToDouble(temp);
            temp = string.Empty;
            int posEnd = 0;
            while (coord[posEnd] != ')' )
                posEnd++;
            temp = coord.Substring(posComma +1, posEnd -posComma -1);
            resultCoord[1,i] = Convert.ToDouble(temp);
            coord = coord.Substring(posEnd+1); 
        }
    } 
    return resultCoord;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   // {array[i, j],2}  добавляем 2 пробела перед значением для красивого вывода отрицательных чисел
            Console.Write($"{array[i, j],2}   ");
        }
        Console.WriteLine();
    }
}

void PrintFigure(double[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int x = (int)array[0,i] + 70;
        int y = (int)array[1,i] +3;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
}

//x1 = scale * x0 − x0
//y1 = scale * y0 - y0
double[,] ScaleFigure(double[,] coord, double scale)     // метод для масштабирования фигуры
{
    for (int i = 0; i < coord.GetLength(1); i++)
    {
        coord[0,i] = (scale * coord[0,i]) - coord[0,0];
        coord[1,i] = (scale * coord[1,i]) - coord[1,0]; 
    }
    return coord;
}    


Console.Clear();
Console.WriteLine($"Введите координаты фигуры в формате (N,N) (N,N) (N,N) (N,N)");
string coord = Console.ReadLine();
coord = TextFormatter(coord);
double[,] coordXY = CoordReader(coord);
PrintArray(coordXY);
PrintFigure(coordXY);
Console.WriteLine();
Console.WriteLine($"Введите коэффициент масштабирования");
double scale = Convert.ToDouble(Console.ReadLine());
coordXY = ScaleFigure(coordXY, scale);
PrintArray(coordXY);
PrintFigure(coordXY);
