using System;

namespace CSharpAdvance
{
    //public delegate void delCalculator(int a, int b);
    class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        //public static void test(delCalculator x)
        //{

        //}
        public static void Test(Action<int, int> x)
        {

        }

        public static double Add1(int a,float b)
        {
            return a + b;
        }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            //database 
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a / b); /**///new DivideByZeroException();

                int[] arr = new int[5];
                Console.WriteLine(arr[10]); //new IndexOutOfRangeException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            finally
            {
                Console.WriteLine("runs always") ;
            }

            //store the method
            //delCalculator del = Calculator.Add;
            //del += Calculator.Sub;
            //del += Calculator.Mul;

            Action<int,int> del = Calculator.Add;
            del += Calculator.Sub;
            del += Calculator.Mul;
            del.Invoke(4, 4);


            Func<int, float, double> func = Calculator.Add1;

            double x=func.Invoke(10, 2.0f);
            Console.WriteLine(x);


            //Calculator.test(del);
        }
    }
}
