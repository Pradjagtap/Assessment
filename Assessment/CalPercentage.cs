using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class CalPercentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of sub1: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of sub2: ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of sub3: ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of sub4: ");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of sub5: ");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            int total = 500;
            Double percent = (sub1 + sub2 + sub3 + sub4 + sub5)*100/total;

            Console.WriteLine("Percentage is: " + percent);

        }
    }
}
