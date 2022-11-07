using System;

class RoyalGuard
{
    public string name = "No name"; // ім'я гвардійця

    public RoyalGuard(string name) => this.name = name; // конструктор

    public void Reaction() => Console.WriteLine($"Royal Guard {name} is defending!"); // реакція гвардійця
}