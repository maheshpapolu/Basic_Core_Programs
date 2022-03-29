using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_Two
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Enter the range of numners; ");
            int range = int.Parse(Console.ReadLine());
             if (range < 32)
            {
                Console.WriteLine("range with in 31");
            }
             else
            {
                int n = range;
                int result = 1;
                while (n > 0)
                {
                    result = result * 2;
                    n--;
                }
                Console.WriteLine("Result of 2 ^ " + n + "is : " + result );
            }
            Console.ReadLine();
        }
    }
}
