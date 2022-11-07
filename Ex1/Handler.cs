using System;

class Handler
{
    public void OnDispatcherNameChange(object sender, NameChangeEventArgs args) // метод який виводить на яке ім'я було змінено
    {
        Console.WriteLine($"Dispatcher’s name changed to {args.Name}.");
    }
}