using System;

namespace Lab
{
    internal class Program
    {
        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int j = 0;
            var y = new double[5];

            for (var i = xn; i < xk; i += dx)
            {
                y[j] = Math.Pow(i * (a + b), 2.5) / (1 + Math.Log10(i * (a + b)));
                j++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];

            for (var i = 0; i < y.Length; i++)
            {
                y[i] = Math.Pow(i * (a + b), 2.5) / (1 + Math.Log10(i * (a + b)));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 2.5;
            const double b = 4.6;
            const double xn = 1.1;
            const double xk = 3.6;
            const double dx = 0.5;
            int count = 1;
            var kakao = TaskA(a, b, xn, xk, dx);
            Console.WriteLine("Task A:");
            foreach (var i in kakao)
            {
                Console.WriteLine($"y{count++} = {i}");
            }

            Console.WriteLine();
            var x = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var slivki = TaskB(a, b, x);
            count = 1;
            Console.WriteLine("Task B:");
            foreach (var i in slivki)
            {
                Console.WriteLine($"y{count++} = {i}");
            }

            Console.ReadKey();
        }
    }
}
