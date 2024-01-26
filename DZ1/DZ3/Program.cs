while (true)
{
        Console.WriteLine("Введите число");
        int x = Convert.ToInt32(Console.ReadLine());


        if (x % 2 == 0)
        {
            Console.WriteLine("Четное");
        }
        else 
        {
            Console.WriteLine("Нечетное");
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