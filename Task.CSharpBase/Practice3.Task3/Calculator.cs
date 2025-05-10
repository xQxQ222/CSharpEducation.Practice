using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task3
{
    class Calculator
    {
        private delegate double mathOperation(double a, double b);

        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Minus(double a, double b)
        {
            return a - b;
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        private double Divide(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0");
            }
            return Double.NaN;

        }
        public double? Calculate(double a, double b, string operationId)
        {
            mathOperation operation = null;
            switch (operationId)
            {
                case "+":
                    operation = Add;
                    break;
                case "-":
                    operation = Minus;
                    break;
                case "*":
                    operation = Multiply;
                    break;
                case "/":
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
            return operation == null ? null : operation(a, b);
        }
    }
}
