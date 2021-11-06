// 14. Найти третью цифру числа или сообщить, что её нет

// int FindThirdDigit(int number)                         // функция для нахождения третьей цифры числа
// {
//     if ( (number < 100) && (number > -100) )           // проверяем, если введенное число находится на отрезке [-99, 99]
//     {                                                  // то третьей цифры в числе нет 
//         return -1;                                     // и функция возвращает "-1"
//     }
//     else                                               // иначе
//     {
//         int digit3 = Math.Abs(number / 100 % 10);      // находим третью цифру числа
//         return digit3;                                 // возвращаем полученное значение
//     }
// }

// Console.WriteLine("Введите целое число:");             // Выводим на экран приглашение ко вводу
// int number = Convert.ToInt32(Console.ReadLine());      // Преобразуем введенное значение в целочисленный тип

// // Вызываем метод для нахождения третьей цифры числа и вывода на экран полученного результата 
// if (FindThirdDigit(number) == -1)      // Если метод вернул -1, то выводим сообщение, что введённое число не содержит третью цифру
//     Console.WriteLine($"Введённое число {number} не содержит третью цифру");
// else                                   // Иначе выводим значение третьей цифры
//     Console.WriteLine($"Третья цифра числа {number} равна: {FindThirdDigit(number)}");

// Console.WriteLine("Введите целое число:");             // Выводим на экран приглашение ко вводу
// int number = Convert.ToInt32(Console.ReadLine());      // Преобразуем введенное значение в целочисленный тип

// // Вызываем метод для нахождения третьей цифры числа и вывода на экран полученного результата 
// if (FindThirdDigit(number) == -1)      // Если метод вернул -1, то выводим сообщение, что введённое число не содержит третью цифру
//     Console.WriteLine($"Введённое число {number} не содержит третью цифру");
// else                                   // Иначе выводим значение третьей цифры
//     Console.WriteLine($"Третья цифра числа {number} равна: {FindThirdDigit(number)}");


//14. Найти третью цифру числа слева или сообщить, что её нет

Console.WriteLine("Введите число:");

int n = Convert.ToInt32(Console.ReadLine());
// string numb = Convert.ToString(n);
// Console.WriteLine($"В числе {n} третья цифра слева равна {numb[2]}, а третья цифра справа равна {numb[numb.Length-3]}");

int razryadnost(int n)
{
    int razr = 0;
    int s = Math.Abs(n);
    while (s >= 1)
    {
        s = s / 10;
        razr++;
    }
    return razr;
}

if (razryadnost(n) < 3)
{
    Console.WriteLine("В указанном числе нет третьей цифры слева");
}
else
{
    int m = (Math.Abs(n)/ Convert.ToInt32(Math.Pow(10, razryadnost(n) - 3))) % 10;
    Console.WriteLine($"Третья циффра заданного числа слева: {m}");
}