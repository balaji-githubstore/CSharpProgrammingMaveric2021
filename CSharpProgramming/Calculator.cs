using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming
{
    class Calculator
    {
        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public static void add(int a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void add(double b, int a)
        {
            Console.WriteLine(a + b);

        }
    }
}
