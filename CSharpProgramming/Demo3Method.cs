using System;



namespace Maveric.CSharpProgramming
{
    class Program1
    {
        static void Main12(string[] args)
        {
            int radius = 10;
            

            double result = Area.AreaOfCircle(radius);
            Console.WriteLine(result);

            radius = 20;
            result = Area.AreaOfCircle(10);
            Console.WriteLine(result);

            int len = 45;
            int wid = 45;

            int res = Area.AreaOfRectangle(len, 10);
            Console.WriteLine("Area of rectangle " + res);

            //Declaration 
            //instantiation
            //intialization

            Area obj = new Area(); //allocate the memory

            result = obj.AreaOfTriangle(25, 1);
            Console.WriteLine(result);

            String name = Area.GetName();
            Console.WriteLine(name);

            Area.Quit();

            obj.PrintTheName();

        }
    }
}
