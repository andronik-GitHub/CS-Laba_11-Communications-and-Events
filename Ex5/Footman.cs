using System;

class Footman
{
    public string name = "No name"; // ім'я піхотинця
    public int life = 2; // життя (кількість потрібних ударів для вбивства)

    public Footman(string name) => this.name = name; // конструктор

    public void Reaction() => Console.WriteLine($"Footman {name} is panicking!"); // реакція піхотинця
}