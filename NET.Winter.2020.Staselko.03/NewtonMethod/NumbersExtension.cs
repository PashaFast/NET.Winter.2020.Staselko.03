using System;

namespace NewtonMethod
{
    /// <summary>
    /// Class NumbersExtension.
    /// </summary>
    public static class NumbersExtension
    {
        public static readonly AppSettings AppSettings;

        static NumbersExtension()
        {
            AppSettings = new AppSettings
            {
                Epsilon = double.Epsilon,
                BitsInByte = 8,
            };
        }

        /// <summary>
        /// Implement an algorithm that allows you to calculate the root
        /// of the n-th power (n ∈ N) from a real number a using the Newton method with a given accuracy (] 0; epsilon [).
        /// </summary>
        /// <param name="number">The real number from which the root is extracted.</param>
        /// <param name="power">Root power.</param>
        /// <param name="accuracy">Accuracy of calculations.</param>
        /// <returns>The root
        /// of the nth degree (n ∈ N) from a real number.</returns>
        /// <exception cref="ArgumentException">Throw when power is negative or zero; accuracy is negative;
        /// even power root from a negative number.</exception>
        public static double FindNthRoot(double number, int power, double accuracy)
        {
            if (power <= 0)
            {
                throw new ArgumentException("power cannot be negative or zero.");
            }

            if (accuracy <= 0)
            {
                throw new ArgumentException(" accuracy cannot be negative.");
            }

            if (number < 0 && power % 2 == 0)
            {
                throw new ArgumentException("it is impossible to extract an even power root from a negative number.");
            }

            if (accuracy > AppSettings.Epsilon)
            {
                throw new ArgumentException("accuracy cannot be more than epsilon");
            }

            double x1 = number - (FunctionValueAtPoint(number, power, number) / DerivativeFunctionAtPoint(power, number));
            double temp = x1 - number;
            double x0;
            while (Math.Abs(temp) > accuracy)
            {
                    x0 = x1;
                    x1 = x0 - (FunctionValueAtPoint(number, power, x0) / DerivativeFunctionAtPoint(power, x0));
                    temp = x1 - x0;
            }

            return x1;
        }

        private static double FunctionValueAtPoint(double number, int power, double x) => Math.Pow(x, power) - number;

        private static double DerivativeFunctionAtPoint(int power, double x) => power * Math.Pow(x, power - 1);
    }
}
