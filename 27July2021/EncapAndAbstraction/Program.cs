using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapAndAbstraction
{
    public class Account
    {
        public int accno;
        private double Balance;
        public double _balance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
            }
        }
        public string name;
        private int PinNum;

        public void setBalance(double balance)
        {
            Balance = balance;
        }
        public void setPinNum(int pinnum)
        {
            PinNum = pinnum;
        }
        //public void getBalance()
        //{
        //    Console.WriteLine(Balance);
        //}
        public void displayAccountDetails()
        {
            Console.WriteLine($"Acc Num: {accno}\nBalance : {Balance}\n" +
                $"Name: {name}\nPinNum: {PinNum}");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Account objAcc = new Account();
            objAcc.accno = 1234;
            //objAcc.setBalance(2000.56);
            //objAcc.getBalance();
            objAcc._balance = 2000.369;

            objAcc.name = "Praveen";
            objAcc.setPinNum(8281);
            objAcc.displayAccountDetails();
            Console.Read();
        }
    }
}
