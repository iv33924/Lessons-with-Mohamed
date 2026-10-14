using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Выберите действие (+, -, *, :): ");
        string operation = Console.ReadLine();

        double result = 0;
        bool isOperationValid = true;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case ":":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Ошибка: На ноль делить нельзя!");
                    isOperationValid = false;
                }
                break;
            default:
                Console.WriteLine("Ошибка: Неверное действие! Можно использовать только +, -, * или :");
                isOperationValid = false;
                break;
        }

        if (isOperationValid)
        {
            Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
