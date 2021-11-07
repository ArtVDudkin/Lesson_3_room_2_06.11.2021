// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y          

// x | y | ¬(X ⋁ Y)   | ¬X ⋀ ¬Y
// 0 | 0 | -(0+0) =1  | (1 * 1) =1
// 0 | 1 | -(0+1) =0  | (1 * 0) =0
// 1 | 0 | -(1+0) =0  | (0 * 1) =0
// 1 | 1 | -(1+1) =0  | (0 * 0) =0

//bool TrueOrFalse(int x, int y)              // функция для проверки инстинности утверждения по входным параметрам                                     
string TrueOrFalse(int x, int y)
{                                                                    
    bool flagX = (x == 1),                  // flagX = true при х = 1, и flagX = false при х = 0                                           
         flagY = (y == 1);                  // flagУ = true при у = 1, и flagУ = false при у = 0 
    string result = string.Empty;
    // if (x == 0) flagX = false;           
    // else flagX = true;                 
                 
    // if (y == 0) flagY = false;
    // else flagY = true;
    bool left =  !(flagX || flagY);         // это левая часть утверждения ¬(X ⋁ Y)
    bool right = !(flagX) && !(flagY);      // это правая часть утверждения ¬X ⋀ ¬Y
  //  return (left == right);                 // возвращает истину, если левая и правая части утверждения равны
    if (left == right)                      // если левая и правая части утверждения равны
        result = $"{x} | {y} | ¬({x} ⋁ {y}) = {left} " + "\t" + $" | ¬{x} ⋀ ¬{y} = {right} "  + "\t  " + "| Истинно"; // выводим это сообщение
    else                                    // иначе выводим это сообщение
        result = $"{x} | {y} | ¬({x} ⋁ {y}) = {left} | ¬{x} ⋀ ¬{y} = {right} | Ложно";
    return result;                          // возвращает итоговую строку
}

Console.Clear();
Console.WriteLine("Таблица истинности для проверки утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
Console.WriteLine("x | y | ¬(X ⋁ Y)   Итог слева    | ¬X ⋀ ¬Y   Итог справа  | Итого утверждение");
for (int i = 0; i <= 1; i++)                // перебираем все значения х=[0,1] и y=[0,1]
    for (int j = 0; j <= 1; j++)            // и передаем эти значения в функцию для проверки истинности утверждения
        {
            Console.WriteLine(TrueOrFalse(i, j)); // выводим на экран значение функции при заданных значениях Х и У
        }