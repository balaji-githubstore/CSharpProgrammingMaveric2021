using CSharpProgramming;
using CSharpProgramming1;
using System;
using System.Collections.Generic;

namespace Maveric.CSharpProgramming
{
    class StudentTest
    {
        static void Main1(string[] args)
        {
            Student.schoolName= "Global";
            Student.schoolAddress = "Global #33";

            Student stu1 = new Student(4);
            Console.WriteLine(stu1.studentName);
            Student stu2 = new Student(1002);

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

            Student[] students = new Student[2];
            students[0] = stu1;
            students[1] = stu2;

            List<Student> listsOfStudent = new List<Student>();
            listsOfStudent.Add(stu1);
            listsOfStudent.Add(stu2);

            Console.WriteLine(listsOfStudent[0].studentName);
            listsOfStudent.ForEach(x => Console.WriteLine(x.studentName));

        }
    }
}
