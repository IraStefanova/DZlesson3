while (true)
{
    Console.WriteLine("Выберите цифру от 1 до 12");
    string selection = Console.ReadLine();

    switch (selection)
    {
        case "12" or "1" or "2":
            Console.WriteLine("Будет зима");
            break;
        case "3" or "4" or "5":
            Console.WriteLine("Будет весна");
            break;
        case "6" or "7" or "8":
            Console.WriteLine("Будет лето");
            break;
        case "9" or "10" or "11":
            Console.WriteLine("Будет осень");
            break;
        default:
            Console.WriteLine("Вы выбрали неизвестный символ");
            break;
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