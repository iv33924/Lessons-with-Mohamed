using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leason1
{
    public class Math
    {
        private int id = 123;
        internal string name;
        protected double Sallary;
        public double percent(double num, double percent)
        {
            return num * percent / 100;
        }

        // 1 - * (умножение)
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // 2 - / (деление)
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        // 3 - - (вычитание)
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // 4 - + (сложение)
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // 5 - sum (сумма массива чисел)
        public double sumArray(double[] numbers)
        {
            return numbers.Sum();
        }

        // 6 - count (количество чисел)
        public int count(double[] numbers)
        {
            return numbers.Length;
        }

        // 7 - max (максимальное число)
        public double max(double[] numbers)
        {
            return numbers.Max();
        }

        // 8 - min (минимальное число)
        public double min(double[] numbers)
        {
            return numbers.Min();
        }

        // 9 - factorial (факториал)
        public int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
                fact *= i;
            return fact;
        }

        // 10 - modulus and int division (деление нацело и остаток)
        public int intDivision(int num1, int num2)
        {
            return num1 / num2;
        }

        public int modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        // 11 - reverse percent (обратный процент)
        public double reversePercent(double val, double percent)
        {
            return val * 100 / percent;
        }
    }
}
