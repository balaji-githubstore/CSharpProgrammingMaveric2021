using CSharpProgramming;
using System;

namespace Maveric.CSharpProgramming
{
    class EmpProgram
    {
        static void Main112(string[] args)
        {
            Employee.companyName = "Maveric";

            Employee emp1 = new Employee();
            emp1.empId = 101;
            emp1.empName = "Peter";
            emp1.empSalary = 5000;

            Console.WriteLine(emp1.GetHashCode());

            Employee.PrintEmployeeDetail(emp1);

            emp1.PrintEmployeeRecord();
            

            Employee emp2 = new Employee();
            emp2.empId = 102;
            emp2.empName = "mark";
            emp2.empSalary = 5000;

            Console.WriteLine(emp2.GetHashCode());

            Employee.PrintEmployeeDetail(emp2);

            emp2.PrintEmployeeRecord();
            Console.WriteLine();

        }
    }
}
