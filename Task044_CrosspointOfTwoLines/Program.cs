// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, k1 b1 и k2 b2 заданы

// y = k1*x + b1
// y = k2*x + b2
// if k1=k2 && b1=b2 то это одна и та же прямая
// if k1=k2 && b1!=b2 то прямые параллельны, точек пересечения нет
// else if k1!=k2    x=(b2-b1)/(k1-k2)     y=(b2*k1 - b1*k2)/(k1-k2)

string TextFormatter(string text)           // метод для форматирования введенной строки, если что-то введено немного не так
{
    string result = String.Empty;
    int length = text.Length;
    if (text[0] == ' ')                     // если строка начинается с пробела
    {
        text = text.Substring(1);           // то удаляем его
        length--;                           // и уменьшаем расчитанную длину строки на 1
    }
    if (text[length -1] != ' ')             // если строка не заканчивается пробелом, то добавляем его
    {   
        text += ' ';                        // это нужно для корректной работы PosNegNumbers
        length++;                           // и увеличиваем расчитанную длину строки на 1
    } 
    for (int i = 0; i < length; i++)
    {
        if (text[i] == ',') result += ' ';  // заменяем запятые пробелами, если они есть
        else result += $"{text[i]}";    
    }
    text = result;                          // обновляем текст
    result = String.Empty;                  // обнуляем контейнер
    for (int i = 0; i < length; i++)
    {                                       // если текущий элемент пробел и следующий элемент тоже пробел, то не копируем его
        if ( (i != (length -1)) && (text[i] == ' ') && (text[i +1] == ' ') ) result += $""; 
        else result += $"{text[i]}";
    }
    // Console.WriteLine(result);
    return result;
}

void GetNumbers(string text, double[] arr)  // метод для извлечения из введенной строки значения коэффициентов уравнения
{
    int index = 0;
    while(text.Length != 0)
    {
        int i = 0;
        string temp = string.Empty;
        while (text[i] != ' ')
        {
            temp += text[i];       
            i++;
        }
        text = text.Substring(i + 1); 
       //Console.WriteLine($"{text}   {temp}");
        arr[index] = Convert.ToDouble(temp);
        index++;   
    }
}

(double x, double y) CrossPoints(double[] arr)      // метод для нахождения точек пересечения прямых
{
    if ( (arr[0] == arr[2]) && (arr[1] == arr[3]) ) return (double.PositiveInfinity, double.PositiveInfinity);   // точек бесконечно, т.к. это одна и та же прямая
    else if ( (arr[0] == arr[2]) && (arr[1] != arr[3]) ) return (double.NaN, double.NaN);       // точек пересечения нет
    else 
        {
            double x = (arr[3] - arr[1]) / (arr[0] - arr[2]);                                   // x = (b2 - b1) / (k1 - k2)
            double y = (arr[3] * arr[0] - arr[1] * arr[2]) / (arr[0] - arr[2]);                 // y = (b2*k1 - b1*k2) / (k1 - k2)
            return (x, y);
        }
}

Console.Clear();
double[] koeff = new double[4];         // Массив для хранения введенных коэффициентов k1 b1 k2 b2
Console.WriteLine($"Введите коэффициенты уравнения у=kx + b, в формате k1 b1 k2 b2");
string text = Console.ReadLine();
text = TextFormatter(text);             // вызываем метод для форматирования введенной строки, если что-то введено не так
GetNumbers(text, koeff);

Console.WriteLine(CrossPoints(koeff));   // вызываем метод расчета точки пересечения прямых