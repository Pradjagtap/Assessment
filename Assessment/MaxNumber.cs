using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class MaxNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2 && num1 == num3)
            {
                Console.WriteLine("These three numbers are equal");
            }
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater than others");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is greater than others");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Num3 is greater than others");
            }
        }
    }
}
