using System;

namespace OOP5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers f = new RationalNumbers(3, 4);
            Console.WriteLine("f = {0};\n", f);

            int a = 10;
            RationalNumbers f1 = f * a;
            Console.WriteLine("f1 = {0} * {1} = {2};\n", f, a, f1);

            RationalNumbers f2 = a * f;
            Console.WriteLine("f2 = {1} * {0} = {2};\n", f, a, f2);

            double d = 1.5;
            RationalNumbers f3 = f + d;
            Console.WriteLine("f3 = {0} + {1} = {2};\n", f, d, f3);

            RationalNumbers f5 = new RationalNumbers(7, 9);
            RationalNumbers f4 = f - f5;
            Console.WriteLine("f2 = {0} - {1} = {2};\n", f, f5, f4);

            RationalNumbers f6 = f / f5;
            Console.WriteLine("f2 = {0} / {1} = {2};\n", f, f5, f6);

            RationalNumbers f7 = new RationalNumbers(3, 4);
            if (f == f7) Console.WriteLine("{0} = {1};\n", f, f7);
            else Console.WriteLine("{0} != {1};\n", f, f7);

            RationalNumbers f8 = new RationalNumbers(1, 9);
            if (f != f8) Console.WriteLine("{0} != {1};\n", f, f8);
            else Console.WriteLine("{0} == {1};\n", f, f8);

            Console.ReadKey();
        }
    }
}
