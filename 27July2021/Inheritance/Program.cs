using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }    
    }
    public class SalesEmployee : Employee
    {
        public int Salary { get; set; } 
        public void display(SalesEmployee se)
        {
            Console.WriteLine($"Employee ID: {EmployeeID}\nEmployee name: {EmployeeName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            SalesEmployee objSales = new SalesEmployee();
            objSales.EmployeeID = 183575;
            objSales.EmployeeName = "Praveen";
            objSales.display(objSales);
            Console.Read();
        }
    }
}
