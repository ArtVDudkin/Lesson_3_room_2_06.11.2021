// 21. Программа проверяет пятизначное число на палиндромом.

string palindrome(int number)
{   
    string result = string.Empty;                           // создаем пустую строку
    int digit1 = number / 10000;                            // находим 1 цифру   
    int digit2 = number / 1000 % 10;                        // находим 2 цифру   
    int digit4 = number / 10 % 10;                          // находим 4 цифру
    int digit5 = number % 10;                               // находим 5 цифру
    if ( (digit1 == digit5) && (digit2 == digit4) )         // если совпадают 1 и 5 цифры, а также 2 и 4 цифры 
        result = $"Число {number} является палиндромом";    // то число является палиндромом
    else
        result = $"Число {number} не является палиндромом"; // иначе число не является палиндромом
    return result;
}

Console.WriteLine("Введите пятизначное число:");            // Выводим на экран приглашение ко вводу
int number = Convert.ToInt32(Console.ReadLine());           // Преобразуем введенное значение в целочисленный тип
while ( (number < 10000) || (number > 99999) )              // Проверяем, является ли введенное число пятизначным 
{
    Console.WriteLine("Введено некорректное значение. Введите пятизначное число!");
    number = Convert.ToInt32(Console.ReadLine());
}

// выводим на экран значение функции проверки заданного числа на палиндром
Console.WriteLine(palindrome(number)); 
