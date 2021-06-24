using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.CSharpProgramming
{
    class Area
    {
        //accessmodifier static returntype methodname(arguments)
        public static double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static int AreaOfRectangle(int length, int width)
        {
            return length * width;
        }

        //areaOfTriangle
        public double AreaOfTriangle(double triangleBase, double height)
        {
            double area = (triangleBase * height) / 2;
            return area;
        }

        public static String GetName()
        {
            return "bala";
        }

        public static void Quit()
        {

        }

        public void PrintTheName()
        {
            Console.WriteLine("balaji");
        }
    }
}
