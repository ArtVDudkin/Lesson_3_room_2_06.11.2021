// 31. Задать массив из 8 элементов и вывести их на экран

string PrintArray(char[] array)
{   
    string result = string.Empty;                                  // Создаем пустую строку 
    for (int index = 0; index < array.Length; index++)
        result += $"{Convert.ToChar(new Random().Next(65,90))} ";  // 65-90 это символы A..Z в таблице кодировок
    return result;
}

char[] array = new char[8];                                         // создаем массив из 8 символов (по умолчанию пустой)

Console.WriteLine("Массив из 8 элементов");
Console.WriteLine(PrintArray(array));                               // вызываем функцию и выводим на экран массив символов