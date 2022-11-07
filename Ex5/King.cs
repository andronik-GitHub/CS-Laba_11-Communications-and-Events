using System;
using System.Collections.Generic;

class King
{
    public string name = "No name"; // ім'я короля

    public delegate void ReactionDel(); // делегат
    public event ReactionDel reaction; // подія типу ReactionDel

    List<RoyalGuard> guards = new(); // колекція гвардійців
    List<Footman> footmen = new(); // колекція піхотинців


    public King(string name) // конструктор
    {
        this.name = name; // ім'я короля
        reaction = delegate () { Console.WriteLine($"King {this.name} is under attack!"); }; // реакція короля без гвардійців і піхотинців
    }


    public void Add(RoyalGuard? royalGuard = null, Footman? footman = null) // додавання гвардійця або піхотинця
    {
        if (royalGuard != null) // якщо додається гвардієць
        {
            guards.Add(royalGuard); // додається в колекцію
            reaction += royalGuard.Reaction; // метод описуючий реакцію додається до події
        }
        else if (footman != null) // якщо дадається піхотинець
        {
            footmen.Add(footman); // додається в колекцію
            reaction += footman.Reaction; // метод описуючий реакцію додається до події
        }
    }
    public void Remove(string name) // видалення (вбивство) за іменем
    {
        for (int i = 0; i < guards.Count; i++) // пошук серед гвардійців
            if (guards[i].name == name) // якщо знайдено співпадіння
            {
                guards[i].life--; // кількість життів зменшується

                if (guards[i].life <= 0) // якщо 0 то гвардієць вбитий
                {
                    reaction -= guards[i].Reaction; // видалення з події
                    guards.Remove(guards[i]); // видалення з колекції}
                }
            }
        for (int i = 0; i < footmen.Count; i++) // пошук серед піхотинців
            if (footmen[i].name == name) // якщо знайдено співпадіння
            {
                footmen[i].life--; // кількість життів зменшується

                if (footmen[i].life <= 0) // якщо 0 то піхотинець вбитий
                {
                    reaction -= footmen[i].Reaction; // видалення з події
                    footmen.Remove(footmen[i]); // видалення з колекції}
                }
            }
    }

    public void ReactionToAttack() // реакція на атаку
    {
        reaction?.Invoke(); // виконується подія
    }
}
