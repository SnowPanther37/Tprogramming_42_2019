using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Xunit.Assert.Equal(0, res);
        }

        [Theory]
        [InlineData(2.5, 4.6, 1.1, 3.6, 0.5)]
        public void TestA_Elements(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            int counter = 0;
            foreach (double elem in res)
            {
                    counter++;
            }

            double massElemExpected = (xk - xn) / dx;
            Xunit.Assert.Equal(massElemExpected, counter);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.0, 0.0, 1.1, 3.6, 0.5);
            var mass = new double[] { 0, 0, 0, 0, 0 };
            Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(1, 2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var res = Program.TaskB(2.5, 4.6, x);
            var expy = new double[] { 95.6597421284176, 105.929786335064, 116.801060432846, 131.24861950568, 304.266557438152 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
