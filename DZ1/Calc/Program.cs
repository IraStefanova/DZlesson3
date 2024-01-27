using System.Security.Cryptography;


    double x;
    double y;
    double r;
    char z;

while (true)
{
    Console.WriteLine("Введите число 1");
    x = double.Parse(Console.ReadLine());
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
        
            if (z != '=')
            {
                Console.WriteLine("Введите число 2");
                y = double.Parse(Console.ReadLine());
            }
        
            if (z == '/')
            {
                x = x / y;
                if (y == 0)
                {
                   Console.WriteLine("Деление на 0 невозможно");
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
                    case '/':
                        x = x / y;
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
                            Console.WriteLine($"Из отрицательного числа {x} нельзя извлечь корень!");
                            continue;
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
    

        Console.WriteLine("Введите е, чтобы покинуть программу");
        string enteredText = Console.ReadLine();
        switch (enteredText)
        {
            case "е":
                Console.WriteLine("ВЫХОД");
                return;

            default:
                Console.WriteLine("ПРОДОЛЖАЕМ");
                break;
        }
    
}
