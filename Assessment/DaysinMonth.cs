using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DaysinMonth
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            num1 = 31;
            num2 = 30;
            num3 = 29;

            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                Console.WriteLine("Days in this month are " + num1);
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                Console.WriteLine("Days in this month are " + num2);
            }
            else if (m == 2)
            {
                Console.WriteLine("Days in this month are 28 or " + num3);
            }
            else
            {
                Console.WriteLine("Month should be between 1 to 12");
            }

        }
    }
}
