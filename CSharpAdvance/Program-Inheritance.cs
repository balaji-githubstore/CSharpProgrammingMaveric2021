using System;

namespace CSharpAdvance
{

    class Parent
    {
        public int pAge;

        public Parent()
        {
            pAge = 45;
        }
        public void ParentFeature()
        {
            Console.WriteLine("parentFeature!!ww");
        }
    }

    class Child : Parent
    {
        public int cAge;
        public Child()
        {
            Console.WriteLine(pAge);
            cAge = 25;
        }
      
        public void ChildFeature()
        {
            Console.WriteLine("childFeature!!");
        }

    }

    class GrandChild : Child
    {
        public int gAge;
        public GrandChild()
        {
            Console.WriteLine(pAge);
            Console.WriteLine(cAge);
            gAge = 15;
        }
    }



    class Program12
    {
        static void Mai2(string[] args)
        {
            //Child c = new Child();

            GrandChild c = new GrandChild();
            c.ParentFeature();
            c.ChildFeature();
            Console.WriteLine(c.pAge);
            Console.WriteLine(c.cAge);
        }
    }
}
