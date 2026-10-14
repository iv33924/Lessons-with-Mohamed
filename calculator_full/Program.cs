using System;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Простой консольный калькулятор ===");

            Console.Write("Введите первое число: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Введите второе число: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Calculator calc = new Calculator();

            double result = calc.Calculate(firstNumber, secondNumber, op);

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}