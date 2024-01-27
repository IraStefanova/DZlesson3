using System.Security.Cryptography;


double x, y, r;
char z;

while (true)
{
    while (true)
    {
        Console.WriteLine("Введите число 1");
    
        if (!Double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Ошибка ввода, введите чиcло!"); 
        }
        else
        {
            break;
        }
    }
        y = 0;
    
    while (true)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию: \n Сложение: + \n Вычитание: -\n Умножение: * \n Деление: / \n Процент от числа: % \n Квадратный корень: ^ \n Результат: =");
            z = Convert.ToChar(Console.ReadLine());    
    
    
            if (z != '-' & z != '+' & z != '*' & z != '/' & z != '%' & z != '^' & z != '=')
            {
                Console.WriteLine("Ошибка ввода, введите правильный арифметический оператор!");
            }
                else
                {
                    break;
                }
        }
        
            if (z != '=' & z != '^')
            {
                while (true)
                {
                    Console.WriteLine("Введите число 2");
                    if (!Double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.WriteLine("Ошибка ввода, введите чиcло!");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            

            if (z == '/')
            {
                if (y == 0)
                {
                    Console.WriteLine("Деление на 0 невозможно");
                }
                else
                {
                    x = x / y;
                }
            }
            
                switch (z)
                {
                    case '+':
                        x = x + y;
                        break;
                    case '-':
                        x = x - y;
                        break;
                    case '*':
                        x = x * y;
                        break;
                    case '%':
                        x = x / 100 * y;
                        break;
                    case '^':
                        if (x > 0)
                        {
                            x = Math.Sqrt(x);
                        }
                        else
                        {
                            Console.WriteLine($"Из отрицательного числа нельзя извлечь корень!");
                            break;
                        }
                        break;
                }
                if (z == '=')
                {
                    r = x;
                    Console.WriteLine("Результат:" + r);
                    break;
                }
    }


    Console.WriteLine("Введите e, чтобы покинуть программу");
    string enteredText = Console.ReadLine();
    switch (enteredText)
    {
        case "e":
            Console.WriteLine("Выход");
            return;

        default:
            Console.WriteLine("Продолжаем");
            break;
    }
}
