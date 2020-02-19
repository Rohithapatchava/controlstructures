using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlstructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the nunber");
            int n = int.Parse(Console.ReadLine());
            while(n<100)
            {
                Console.WriteLine("{0} is less than 100", n);
                n = n + 10;
            }
        }
    }
}
