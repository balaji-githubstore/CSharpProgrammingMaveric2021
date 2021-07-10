using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming
{
    public class Employee
    {
        public int empId;
        public String empName;
        public double empSalary;
        public static String companyName;

        //printemployeedetail
        public static void PrintEmployeeDetail(Employee emp)
        {
            
            Console.WriteLine(emp.GetHashCode());
            Console.WriteLine(emp.empId);
            Console.WriteLine(emp.empName);
            Console.WriteLine(emp.empSalary);

            Console.WriteLine(Employee.companyName);
        }
        public void PrintEmployeeRecord()
        {
            Console.WriteLine(this.GetHashCode());
            empId = 5001;
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(Employee.companyName);
        }

    }
}
