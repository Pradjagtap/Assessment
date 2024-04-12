using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    //wac to calculate the five subject percentage and as per the percentage display the grade
    public class PercentGrade
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
            Double percent = (sub1 + sub2 + sub3 + sub4 + sub5) * 100 / total;

            Console.WriteLine("Percentage is: " + percent);

            if(percent>=90 && percent<100)
            {
                Console.WriteLine("Grade A+");
            }
            else if(percent>=80 && percent<90 )
            {
                Console.WriteLine("Grade A");
            }
            else if (percent >= 70 && percent < 80)
            {
                Console.WriteLine("Grade B+");
            }
            else if (percent >= 60 && percent < 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (percent >= 50 && percent < 35)
            {
                Console.WriteLine("Grade C");
            }
            else 
            {
                Console.WriteLine("Fail");
                //student fails

            }
        }
    }
}
