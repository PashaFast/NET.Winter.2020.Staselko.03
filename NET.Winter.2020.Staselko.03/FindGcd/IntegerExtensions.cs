using System;

namespace FindGcd
{
    /// <summary>
    /// Class IntegerExtensions.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculate time of Euclidean Algorithm(two numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <returns>Time of working.</returns>
        public static long TimeOfGetGcdByEuclidean(int a, int b)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByEuclidean(a, b);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Euclidean Algorithm(two numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <returns>Gcd of two numbers.</returns>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if ((a == 0) && (b == 0))
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            return GetGcdByEuclideanHelper(a, b);
        }

        /// <summary>
        /// Calculate time of Euclidean Algorithm(three numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <param name="c">third number.</param>
        /// <returns>Time of working.</returns>
        public static long TimeOfGetGcdByEuclidean(int a, int b, int c)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByEuclidean(a, b, c);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Euclidean Algorithm(of three numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <param name="c">third number.</param>
        /// <returns>Gcd of three numbers.</returns>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            int temp = GetGcdByEuclideanHelper(a, b);
            return GetGcdByEuclideanHelper(temp, c);
        }

        /// <summary>
        /// Calculates time of Euclidian Algoritm(more than three numbers).
        /// </summary>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Return time of work algoritm.</returns>
        public static long TimeOfGetGcdByEuclidian(params int[] numbers)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByEuclidean(numbers);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Euclidean Algorithm(more than three numbers).
        /// </summary>
        /// <param name="arr">Input numbers.</param>
        /// <returns>Gcd of numbers.</returns>
        public static int GetGcdByEuclidean(params int[] arr)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == int.MinValue)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = GetGcdByEuclideanHelper(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculate time of Stein Algorithm(two numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <returns>Time of working.</returns>
        public static long TimeOfGetGcdByStein(int a, int b)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByStein(a, b);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// SteinAlgorithm(two numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <returns>Gcd of two numbers.</returns>
        public static int GetGcdByStein(int a, int b)
        {
            if ((a == 0) && (b == 0))
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            return GetGcdBySteinHelper(a, b);
        }

        /// <summary>
        /// Calculate time of Stein Algorithm(three numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <param name="c">third number.</param>
        /// <returns>Time of working.</returns>
        public static long TimeOfGetGcdByStein(int a, int b, int c)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByStein(a, b, c);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Stein Algorithm(three numbers).
        /// </summary>
        /// <param name="a">first number.</param>
        /// <param name="b">second number.</param>
        /// <param name="c">third number.</param>
        /// <returns>Gcd of three numbers.</returns>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if ((a == 0) && (b == 0) && (c == 0))
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            int temp = GetGcdBySteinHelper(a, b);
            return GetGcdBySteinHelper(temp, c);
        }

        /// <summary>
        /// Calculate time of Stein Algorithm(more than three numbers).
        /// </summary>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Time of working.</returns>
        public static long TimeOfGetGcdByStein(params int[] numbers)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetGcdByStein(numbers);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Stein Algorithm(more than three numbers).
        /// </summary>
        /// <param name="arr">Input numbers.</param>
        /// <returns>Gcd of numbers.</returns>
        public static int GetGcdByStein(params int[] arr)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                throw new ArgumentException("Numbers cannot to be int.MinValue");
            }

            flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == int.MinValue)
                {
                    flag = true;
                }
            }

            if (flag == true)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = GetGcdBySteinHelper(Math.Abs(arr[i]), Math.Abs(result));

                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        }

        private static int GetGcdBySteinHelper(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if ((~a & 1) == 1)
            {
                if ((b & 1) == 1)
                {
                    return GetGcdBySteinHelper(a >> 1, b);
                }
                else
                {
                    return GetGcdBySteinHelper(a >> 1, b >> 1) << 1;
                }
            }

            if ((~b & 1) == 1)
            {
                return GetGcdBySteinHelper(a, b >> 1);
            }

            if (a > b)
            {
                return GetGcdBySteinHelper((a - b) >> 1, b);
            }

            return GetGcdBySteinHelper((b - a) >> 1, a);
        }

        private static int GetGcdByEuclideanHelper(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0)
            {
                return b;
            }

            return GetGcdByEuclideanHelper(b % a, a);
        }
    }
}
