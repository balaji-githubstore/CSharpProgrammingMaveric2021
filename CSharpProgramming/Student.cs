using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming1
{
    class Student
    {
        private int _studentRollNumber;
        public String studentName;
        public String studentMailId;
        public String studentAddress;
        public double studentPercentage;
        public static String schoolAddress;
        public static String schoolName;


        //public int getStudentRollNumber()
        //{
        //    return _studentRollNumber;
        //}

        //public void setStudentRollNumber(int rollNo)
        //{
        //    if (rollNo > 0)
        //    {
        //        _studentRollNumber = rollNo;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not valid");
        //    }
        //}

        public int StudentRollNumber
        {
            get { return _studentRollNumber; }

            set
            {
                if(value>0)
                {
                    _studentRollNumber = value;
                }
                else
                {
                    Console.WriteLine("Negative value not allowed! _studentRollNumber is with default value");
                }
            }
        }

        public static void PrintStudentDetail(Student stu)
        {
            Console.WriteLine(stu._studentRollNumber);
            Console.WriteLine(stu.studentName);
            Console.WriteLine(stu.studentMailId);
            Console.WriteLine(stu.studentPercentage);
            Console.WriteLine(stu.studentAddress);

            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.schoolAddress);

            Console.WriteLine("----------------------------");
        }

        public void PrintStudentRecord()
        {
            //studentRollNumber = 5000;
            Console.WriteLine(_studentRollNumber);
            Console.WriteLine(studentName);
            Console.WriteLine(studentMailId);
            Console.WriteLine(studentPercentage);
            Console.WriteLine(studentAddress);

            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.schoolAddress);

            Console.WriteLine("----------------------------");
        }

        public static Student CreateStudentInstance()
        {
            Student stu = new Student();
            return stu;
        }

        public static Student Id(String idText)
        {
            return null;
        }

    }
}
