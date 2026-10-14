using System;

namespace Calculator2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("0 - percent\n");
                Console.Write("1 - *\n");
                Console.Write("2 - /\n");
                Console.Write("3 - -\n");
                Console.Write("4 - +\n");
                Console.Write("5 - sum\n");
                Console.Write("6 - count\n");
                Console.Write("7 - max\n");
                Console.Write("8 - min\n");
                Console.Write("9 - factorial\n");
                Console.Write("10 - modulus and int division\n");
                Console.Write("11 - reverse percent\n");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result: " + (num1 * num2) + "\n");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result: " + (num1 / num2) + "\n");
                }
                else if (choice == "3")
                {
                    Console.Write("Enter number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result: " + (num1 - num2) + "\n");
                }
                else if (choice == "4")
                {
                    Console.Write("Enter number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result: " + (num1 + num2) + "\n");
                }
                else if (choice == "5")
                {
                    double sum = 0;
                    Console.Write("Enter numbers (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0) break;
                        sum += n;
                    }
                    Console.Write("Sum: " + sum + "\n");
                }
                else if (choice == "6")
                {
                    int count = 0;
                    Console.Write("Enter numbers (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0) break;
                        count++;
                    }
                    Console.Write("Count: " + count + "\n");
                }
                else if (choice == "7")
                {
                    double max = double.MinValue;
                    Console.Write("Enter numbers (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0) break;
                        if (n > max) max = n;
                    }
                    Console.Write("Max: " + max + "\n");
                }
                else if (choice == "8")
                {
                    double min = double.MaxValue;
                    Console.Write("Enter numbers (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0) break;
                        if (n < min) min = n;
                    }
                    Console.Write("Min: " + min + "\n");
                }
                else if (choice == "9")
                {
                    Console.Write("Enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int fact = 1;
                    for (int i = 1; i <= num; i++)
                        fact *= i;
                    Console.Write("Factorial: " + fact + "\n");
                }
                else if (choice == "10")
                {
                    Console.Write("Enter number 1: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Int division: " + (num1 / num2) + "\n");
                    Console.Write("Modulus: " + (num1 % num2) + "\n");
                }
                else if (choice == "11")
                {
                    Console.Write("Enter percent value: ");
                    double val = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter percent: ");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Original number: " + (val * 100 / percent) + "\n");
                }
                else if (choice == "0")
                {
                    Console.Write("Enter number: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter percent: ");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Percent: " + (num * percent / 100) + "\n");
                }

                Console.Write("Do you want to continue? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N") break;
            }
        }
    }
}