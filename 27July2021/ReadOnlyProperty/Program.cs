using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperty
{
    public class Employee
    {
        private int EmpID;

        public int _empid
        {
            get { return EmpID; }
            //set { EmpID = value; }
        }
        private string EmpName;

        public string _empname//read only
        {
            get { return EmpName; } 
            //set { EmpName = value; }//employee id is not need to change
        }
        private int Age;

        public int _age//read-write
        {
            get { return Age; } 
            set {
                if (value > 18)
                {
                    Age = value;
                }
                //throw new ArgumentException("Age cant be less than 18");
                else
                {
                    Console.WriteLine("Age cant be less than 18");
                }
            }
        }
        public Employee(int empid, string empname)
        {
            if (empid > 0 && empname != string.Empty)
            {
                EmpID = empid;
                EmpName = empname;
            }
        }
        public void displayDetails()
        {
            Console.WriteLine($"EmployeeID: {EmpID}\nEmployeeName: {EmpName}\nEmployeeAge: {Age}");
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(empid:183575, empname:"praveen");
            obj._age = 17;
            obj.displayDetails();
            Console.Read();


        }
    }
}
