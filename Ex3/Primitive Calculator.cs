using System;

class Primitive_Calculator
{
    char strategy = '+'; // тип операції

    ICalculator Calculator { get; set; } // інтерфейс який реалізовує різні операції

    public Primitive_Calculator() => Calculator = new CalculatorAddition(); // за замовчування додавання


    public void ChangeStrategy(char @operator) => strategy = (  @operator == '+' ||
                                                                @operator == '-' ||
                                                                @operator == '*' ||
                                                                @operator == '/') ?
                                                                @operator : strategy;

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        if (strategy == '+') Calculator = new CalculatorAddition(); // додавання (перевиділяється пам'ять)
        else if (strategy == '-') Calculator = new CalculatorSubtraction(); // віднімання (перевиділяється пам'ять)
        else if (strategy == '*') Calculator = new CalculatorMultiply(); // множення (перевиділяється пам'ять)
        else if (strategy == '/') Calculator = new CalculatorDivision(); // ділення (перевиділяється пам'ять)
        else throw new Exception("Invalid operation!");

        return Calculator.Calculation(firstOperand, secondOperand); // результат
    }
}