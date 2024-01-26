while (true)
{
    Console.WriteLine("Выберите цифру от 1 до 12");
int x = Convert.ToInt32(Console.ReadLine());


        if (x == 12 || x == 1 || x == 2)
        {
            Console.WriteLine("Это зима");
        }
        else if (x == 3 || x == 4 || x == 5)
        {
            Console.WriteLine("Это весна");
        }
        else if (x == 6 || x == 7 || x == 8) 
        {
            Console.WriteLine("Это лето");
        }
        else if (x == 9 || x == 10 || x == 11)
        {
            Console.WriteLine("Это осень");
        }

        Console.WriteLine("Введите exit, чтобы покинуть программу");
        string enteredText = Console.ReadLine();
        switch (enteredText)
        {
            case "exit":
                Console.WriteLine("ВЫХОД");
                return;

            default:
                Console.WriteLine("ПРОДОЛЖАЕМ");
                break;
        }

}