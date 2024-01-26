while (true)
{
    Console.WriteLine("Выберите цифру от 1 до 7");
    string selection = Console.ReadLine();

        switch (selection)
        {
            case "1":
                Console.WriteLine("Красный");
                break;
            case "2":
                Console.WriteLine("Оранжевый");
                break;
            case "3":
                Console.WriteLine("Желтый");
                break;
            case "4":
                Console.WriteLine("Зеленый");
                break;
            case "5":
                Console.WriteLine("Голубой");
                break;
            case "6":
                Console.WriteLine("Синий");
                break;
            case "7":
                Console.WriteLine("Фиолетовый");
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
