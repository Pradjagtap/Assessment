using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
