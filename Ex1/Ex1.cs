using System;

class Ex1
{
    static void Main()
    {
        Dispatcher dispatcher = new();
        Handler handler = new();
        dispatcher.NameChange += handler.OnDispatcherNameChange; // в подію додається делегат

        while (true)
        {
            string? action = Console.ReadLine();

            if (action?.ToLower() == "end") break;
            else if (action != null)
                dispatcher.Name = action; // ім'я змінюється і повинно виводитись повідомлення про це
        }

        Console.ReadKey();
    }
}