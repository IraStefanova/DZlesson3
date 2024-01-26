while (true)
{
    Console.WriteLine("Введите температуру");
    int t = Convert.ToInt32(Console.ReadLine());


        if (t > -5)
        {
            Console.WriteLine("Тепло");
        }
        else if (-5 >= t & t > -20)
        {
            Console.WriteLine("Нормально");
        }
        else if (-20 >= t)
        {
            Console.WriteLine("Холодно");
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