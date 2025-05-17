namespace MathHelper
{
    public class MathHelper
    {

        public double Solve(double a, double b, string functionSign)
        {
            switch (functionSign)
            {
                case "+":
                    return Plus(a, b);
                case "-":
                    return Minus(a, b);
                case "*":
                    return Multiply(a, b);
                case "/":
                    return Divide(a, b);
                default:
                    return double.NaN;
            }
        }
        private static double Plus(double a, double b)
        {
            return a + b;
        }

        private static double Minus(double a, double b)
        {
            return a - b;
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Divide(double a, double b)
        {
            if (b == 0)
            {
                return a < 0 ? double.NegativeInfinity : double.PositiveInfinity;
            }
            return a / b;
        }
    }
}
