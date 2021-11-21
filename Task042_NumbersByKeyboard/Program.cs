// 42. Определить сколько чисел больше 0 введено с клавиатуры

// string KeyboardPositiveNum()
// {
//     int count = 0;
//     int countPos = 0;
//     double number;
//     while (Console.ReadKey(true).Key != ConsoleKey.Escape) 
//     {
//         number = Convert.ToDouble(Console.ReadLine());
//         if (number > 0) countPos++;
//         count++;
//     }
//     return $"Всего введено чисел {count}, из них положительных {countPos}";
// }

// Console.Clear();
// Console.WriteLine($"Введите положительные и отрицательные числа с клавиатуры. (Для выхода нажать Esc)");
// Console.WriteLine(KeyboardPositiveNum());

string TextFormatter(string text)
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

int PosNegNumbers(string text, int positiv)
{
    int counter = 0;
    int numb = 0;
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
       // Console.WriteLine($"{text}   {temp}");
        numb = Convert.ToInt32(temp);
        if (positiv == 1)                   // если параметр positiv =1, считаем количество чисел > 0
            if (numb > 0) counter++;
        if (positiv == 0)                   // если параметр positiv =0, считаем количество чисел < 0
            if (numb < 0) counter++;      
    }
    return counter;
}

Console.Clear();
Console.WriteLine($"Введите положительные и отрицательные числа с клавиатуры");
string text = Console.ReadLine();
text = TextFormatter(text);
Console.WriteLine(PosNegNumbers(text, 1)); // 1 - считаем количество чисел > 0; 0 - считаем количество чисел < 0