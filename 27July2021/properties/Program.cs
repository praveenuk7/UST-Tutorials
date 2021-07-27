using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Account
    {
        private int AccId;
        public int _AccId
        {
            get            {                return AccId;            }
            set            {                AccId = value;            }
        }
        private string Name;
        public string _name
        {
            get {return Name;}           
            set {Name = value;}
        }
        private double Balance;

        public double _balance
        {
            get { return Balance; }
            set { Balance = value; }
        }
        private int PinNum;

        public int _pinnum
        {
            get { return PinNum; }
            set { PinNum = value; }
        }
        public void displayDetails()
        {
            Console.WriteLine($"AccountID={AccId}\nAccounName = {Name}\nPinNum = {PinNum}\nBalance = {Balance}");
        }

            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj._AccId = 183575;
            obj._name = "Praveen";
            obj._pinnum = 8281;
            obj._balance = 2000.369;
            obj.displayDetails();
            Console.Read();
            
        }
    }
}
