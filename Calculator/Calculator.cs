using System;

namespace CalculatorLogic
{
    public static class Calculator
    {
        public static double Add(double number1, double number2) => number1 + number2;

        public static double Subtract(double number1, double number2) => number1 - number2;

        public static double Multiply(double number1, double number2) => number1 * number2;

        public static double Divide(double number1, double number2) => number1 / number2;

        public static double Square(double number) => number * number;

        public static double SquareRoot(double number) => Math.Sqrt(number);
    }
}