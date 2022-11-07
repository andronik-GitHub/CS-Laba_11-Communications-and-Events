using System;

class Ex5
{
    static void Main()
    {
        King king = new(""); // король

        for (int i = 0; true; i++)
        {
            string[]? action = Console.ReadLine()?.Split(' '); // зчитується команда

            if (action != null)
            {
                if (action[0]?.ToLower() == "end") break; // якщо "end" то завершення вводу

                else if (i == 0) // перша строка вводу створює короля
                    king = new(action[0]);
                else if (i == 1) // друга строка вводу створює гвардійців
                    foreach (string item in action)
                        king.Add(new RoyalGuard(item));
                else if (i == 2) // третя строка вводу створює піхотинців
                    foreach (string item in action)
                        king.Add(null, new Footman(item));
                else if (i > 2) // четверга і далі строки зчитують дії атаки, вбивства або завершення вводу
                {
                    if (action[0].ToLower() == "attack" && action[1].ToLower() == "king") // якщо король атакований
                        king.ReactionToAttack(); // метод який виконує подію
                    else if (action[0].ToLower() == "kill") // якщо вбивство
                        king.Remove(action[1]); // видалення (вбивство) гвардійця або піхотинця (пошук за іменем)
                }
            }
        }


        Console.ReadKey();
    }
}