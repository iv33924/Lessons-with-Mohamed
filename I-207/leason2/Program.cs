using System;

class Program
{
    static void Main()
    {
        // Поддержка русского языка в консоли
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // 1. Ввод первого числа
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // 2. Ввод второго числа
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // 3. Выбор действия
        Console.Write("Выберите действие (+, -, *, :): ");
        string operation = Console.ReadLine();

        double result = 0;
        bool isOperationValid = true; // Флаг проверки правильности действия

        // 4. Проверка действия и вычисление
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
                // Если введено любое другое действие, фиксируем ошибку
                Console.WriteLine("Ошибка: Неверное действие! Можно использовать только +, -, * или :");
                isOperationValid = false;
                break;
        }

        // 5. Вывод правильного ответа (только если действие было корректным)
        if (isOperationValid)
        {
            Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
        }

        // Задерживаем экран, чтобы консоль не закрылась сразу
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
