using System;

namespace CSharpAdvance
{
    abstract  class Doctor
    {
        public void DoctorDetail()
        {
            Console.WriteLine("title!!");
        }
        public void WorkPlace()
        {
            Console.WriteLine("gobal hos!!");
        }
        public virtual void Work()
        {
            Console.WriteLine("treats patients!!!");
        }

        public abstract void CalculateSalary();
        
    }

    class Dentist : Doctor
    {
        public override void CalculateSalary()
        {
            Console.WriteLine();
        }

        public override void Work()
        {
            Console.WriteLine("treats issues related to teeth issues!!!");
        }
    }
 
    class FamilyDoctor : Doctor
    {
        public override void CalculateSalary()
        {
            Console.WriteLine();
        }

        public override void Work()
        {
            Console.WriteLine("Address the patient in home!!");
        }
    }

    class Program1
    {
        static void Main1(string[] args)
        {
            

            Doctor d = new Dentist();
            d.DoctorDetail();
            d.WorkPlace();
            d.Work();
            d.Work();
           

            Doctor f = new FamilyDoctor();
            f.DoctorDetail();
            f.WorkPlace();
            f.Work();
        }
    }
}
