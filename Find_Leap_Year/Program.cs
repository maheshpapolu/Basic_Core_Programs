using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year : ");
            int Year =  int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("{0} is a Leap year. ", Year);
            else
                Console.WriteLine("{0} is not a Leap Year. ", Year);
        }
    }
}
