using CSharpProgramming;
using CSharpProgramming1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maveric.CSharpProgramming
{
    class Program
    {
        //public static bool checkE(List<string> colors, string checkE)
        //{
        //    foreach (string c in colors)
        //    {
        //        if (c.Contains("e"))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public static bool checkE(string input)
        {
            return input.Contains("e");
        }
        static void Main(string[] args)
        {

            int a = 10;
            int b = 0;

            Console.WriteLine(b/a);

            //add a method to existing class using C# extension
            Employee e = new Employee();
            e.EmpTest(2);

            List<int> numbers = new List<int> { 1, 2, 65, 85, 75,65 };

            var output=  numbers.Where(x => x > 50);

           int firstmatchingValue= numbers.First(x => x == 65);

            foreach(var i in output)
            {
                Console.WriteLine(i);
            }    


            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("green");
            colors.Add("pink");

           
            //replace with query and method syntax
            foreach (string color in colors)
            {
                Console.WriteLine(Program.checkE(color));
                
            }


            //Query syntax
            var lists = from color in colors
                        where color.Contains("e")
                        select color;


            foreach(string s in lists)
            {
                Console.WriteLine(s);
            }

            //method syntax

            var lists1= colors.Where(x => x.Contains("e"));

            foreach (string s in lists1)
            {
                Console.WriteLine(s);
            }

            //colors.ForEach(color => Console.WriteLine(color+" "+color.Length));


            //for(int i=0;i<colors.Count ;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //foreach(string color in colors)
            //{
            //    Console.WriteLine(color+" "+color.Length);
            //}

        }
    }
}
