using System;

namespace Calculator
{
    public class Calculator
    {
        public double CurrentValue;

        public double Sum(double firstValue, double secondValue)
        {
            var result = firstValue + secondValue;

            return result;
        }

        public double Subtraction(double firstValue, double secondValue)
        {
            var result = firstValue - secondValue;

            return result;
        }

        public double Multiplication(double firstValue, double secondValue)
        {
            var result = firstValue * secondValue;

            return result;
        }

        public double Division(double firstValue, double secondValue)
        {
            var result = firstValue / secondValue;

            return result;
        }

        public double CheckIfIsNumber(string number)
        {
            var insertedNumber = 0d;

            try
            {
                insertedNumber = Convert.ToDouble(number);
            }
            catch { Console.WriteLine("IDK"); };

            return insertedNumber;
        }
    }
}
