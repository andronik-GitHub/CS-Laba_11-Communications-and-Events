using System;

class Ex3
{
    static void Main()
    {
        Primitive_Calculator calculator = new(); // створюється калькулятор(додавання за замовчуванням)

        while (true) // ввід команд
        {
            string[]? action = Console.ReadLine()?.Split(' '); // розбивається на масив підстрок

            if (action != null) // якщо зчитана не пуста строка
            {
                try // безпечне виконання коду
                {
                    if (action[0].ToLower() == "end") break; // завершення вводу

                    else
                    {
                        if (action[0].ToLower() == "mode") // якщо mode то значить змінюється тип операції
                            calculator.ChangeStrategy(Convert.ToChar(action[1])); // змінюється тип операції
                        else
                            Console.WriteLine(calculator.PerformCalculation // виводиться результат операції
                                (
                                    Convert.ToInt32(action[0]), // пераметри конвертуються в цілі числа
                                    Convert.ToInt32(action[1])  // пераметри конвертуються в цілі числа
                                ));
                    }
                }
                catch (Exception e) // виключення
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        Console.ReadLine();
    }
}