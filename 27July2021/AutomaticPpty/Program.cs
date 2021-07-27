using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticPpty
{
    class Employee
    {
        //automatic property
        public int EmpId { get;  }
        public string EmpName { get;  }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee(int empid, string empname)
        {
            EmpId = empid;
            EmpName = empname;
        }
        public void displayDetails()
        {
            Console.WriteLine($"EmployeeID: {EmpId}\nEmployeeName: {EmpName}\nEmployeeAge: {Age}\nSalary = {Salary}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(empid:183575, empname:"Praveen");
            obj.Age = 24;
            obj.Salary = 25000;
            obj.displayDetails();
            Console.Read();
        }
    }
}
