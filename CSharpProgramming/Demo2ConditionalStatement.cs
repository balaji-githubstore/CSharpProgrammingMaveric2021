using System;

namespace Maveric.CSharpProgramming
{
    class Demo2
    {
        static void Main12(string[] args)
        {
            String a = Console.ReadLine();

            int z = Convert.ToInt32(a);

            // String b = Console.ReadLine();
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(z + y);

            String browser = Console.ReadLine();


            if (browser == "ch")
            {
                Console.WriteLine("chrome");
            }
            else if (browser == "ff")
                Console.WriteLine("hhh");
            Console.WriteLine("jjdjf");






            // assume we are reading from external file

            //if (browser == "ch")
            //{
            //    Console.WriteLine("launch Chrome browser");
            //}
            //else
            //{
            //    Console.WriteLine("launch firefox browser");
            //}

            if (browser == "ch" || browser == "chrome" || browser == "gc")
            {
                Console.WriteLine("launch Chrome browser");
            }
            else if (browser == "ff")
            {
                //Console.WriteLine("launch firefox browser");
            }
            else if (browser == "ie")
            {
                Console.WriteLine("launch internet explorer browser");
            }
            else
            {
                Console.WriteLine("launch firefox browser");
            }

            int number = 150;

            if (number > 100)
            {
                if (number < 200)
                {
                    Console.WriteLine("between 100 & 200");
                }
            }

            if (number > 100 && number < 200)
            {
                Console.WriteLine("between 100 & 200");
            }

            Console.WriteLine(!true);

            bool termAndConditionSelected = true; //true --> selected

            if (termAndConditionSelected)
            {
                //already checked
            }
            else
            {
                //click on it
                Console.WriteLine("click on it");
            }

            if (!termAndConditionSelected)
            {
                Console.WriteLine("click on it");
            }
            //1 to 10
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine("i=" + i);
            }

            int[] numbers = { 45, 75, 12, 58, 85, 98, 52 }; //length -->7

            for (int i = 0; i < 7; i = i + 1)
            {
                Console.WriteLine("index is " + i + " value numbers[i]" + numbers[i]);
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            String[] colors = new string[3];
            colors[0] = "red";

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }


            //1 to 10
            /*int a = 1;

            while (a <= 10)   //until popup available
            {
                Console.WriteLine(a);
                a = a + 1;
            }
   
            do
            {
                Console.WriteLine(a);
                a = a + 1;
            } while (a <= 10);

            Console.WriteLine("end");
*/
        }
    }
}
