using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 100 == 0 && year % 400 == 0) || year % 4 == 0)
            {
                Console.WriteLine("This year is a leap year");
            }
            else
            {
                Console.WriteLine("This year is not a leap year");
            }
        }
    }
}
