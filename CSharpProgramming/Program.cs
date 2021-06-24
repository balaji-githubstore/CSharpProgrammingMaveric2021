using CSharpProgramming;
using CSharpProgramming1;
using System;

namespace Maveric.CSharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.schoolName= "Global";
            Student.schoolAddress = "Global #33";

            Student stu1 = new Student();

            Student stu2 = new Student();

            //Student stu3=Student.Id("lll");

            //Student stu1 = Student.CreateStudentInstance();
            //Student stu2 = Student.CreateStudentInstance();

            //Student.PrintStudentDetail(stu1);

            //stu1.studentRollNumber = -1001;


            stu1.StudentRollNumber = 1001;
            stu1.studentName = "jack";
            stu1.studentMailId = "jack@gmail.com";
            stu1.studentAddress = "jack #12";
            stu1.studentPercentage = 88.8;

            int no = stu1.StudentRollNumber;
            Console.WriteLine(no);

            //Student.PrintStudentDetail(stu1);
           
            stu2.StudentRollNumber = 1002;
            stu2.studentName = "Peter";
            stu2.studentMailId = "Peter@gmail.com";
            stu2.studentAddress = "Peter #12";
            stu2.studentPercentage = 55.8;

            //Student.PrintStudentDetail(stu2);


            stu1.PrintStudentRecord();
            stu2.PrintStudentRecord();

        }
    }
}
