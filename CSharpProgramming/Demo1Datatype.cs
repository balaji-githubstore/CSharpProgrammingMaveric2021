using Maveric.CSharpProgramming;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming
{
    class Demo1Datatype
    {
        static void Main1(string[] args)
        {

        //    double area = Program.AreaOfCircle(4);
            //areaofcircle
            //areaoftriangle
            byte a = 30; //8 bits 

            int b = 25; //32 bits //size, range, default values

            b = 20;
            b = a;   //implicit conversion // will not lead to dataloss

            char c = '3';
            bool check = true;

            float z = 10.9f;
            double zz = 10.123456789;

            Console.WriteLine(zz);
            zz = z;

            z = (float)zz; //explicit conversion //data loss

            Console.WriteLine(z);


            //percentage --> 0 to 200 --> 1000 students

            //int --> 32bits *1000 = 32000 bits of memory 
            //byte --> 8 bits *1000 = 8000 bits of memory


            String name = "bala"; //4*16 
            Console.WriteLine(name); //b


            //store 5 integer
            int[] numbers = new int[5];  //5*32 bits of memory occupied
            numbers[0] = 45;
            numbers[1] = 45;
            numbers[2] = 45;
            numbers[3] = 45;
            numbers[4] = 55;

            Console.WriteLine(numbers.GetHashCode());
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[4]);

            String[] colors = new string[3];
            colors[0] = "red";
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
        }
    }

}