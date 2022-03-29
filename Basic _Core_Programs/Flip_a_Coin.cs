using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic__Core_Programs
{
    internal class Flip_a_Coin
    {
        public static void Main ()
        {
            Console.WriteLine("Welcome to Flip_a_Coin program");
            int heads = 0;
            int tails = 0;
            int count = int.Parse(Console.ReadLine());
            while (count > 0)
            {
                Random random = new Random();
                int randomCheck = random.Next(0, 2);
                if (randomCheck == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                count--;
            }
            Console.WriteLine("Number of heads is : " + heads);
            Console.WriteLine("Number of tails is : " + tails);
            Console.ReadLine();
        }
    }
}