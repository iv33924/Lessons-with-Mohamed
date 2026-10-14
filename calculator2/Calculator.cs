using System;

public class Calculator
{
    public double Calculate(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно!");
                    return 0;
                }
                return num1 / num2;
            default:
                Console.WriteLine("Неверная операция!");
                return 0;
        }
    }
}
