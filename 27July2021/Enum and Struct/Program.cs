using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_and_Struct
{
    //enum dept
    //{
    //    sales=1,
    //    marketing=9,
    //    development,
    //    testing
    //};
    struct coordinates
    {
        public int x;
        public int y;

        public coordinates(int a, int b)
        {
            this.x = a;
            this.y = b;
        }
        public void display()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)dept.development);

            //struct
            coordinates point = new coordinates();
            point.x = 30;
            point.y = 10;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            //from struct constructor
            Console.WriteLine("from struct constructor");
            point.display();
            Console.Read();
        }
    }
}
