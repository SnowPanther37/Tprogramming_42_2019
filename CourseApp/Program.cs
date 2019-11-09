using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b,  double x)
        {
            var y = Math.Pow(a + (b * x), 2.5) / (1 + Math.Log10(a + (b * x)));
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int i = 0;
            var y = new double[(int)((xk - xn) / dx)];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b,  x[i]);
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
            Console.WriteLine("Task A:");
            foreach (var i in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"y{count++} = {i}");
            }

            Console.WriteLine();
            var x = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            count = 1;
            Console.WriteLine("Task B:");
            foreach (var i in TaskB(a, b, x))
            {
                Console.WriteLine($"y{count++} = {i}");
            }

            Console.ReadKey();
        }
    }
}
