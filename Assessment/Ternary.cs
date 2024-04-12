using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{

    //wac to find out the number is positive negarive or zero using ternary operator.
    public class Ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            String result = (num > 0) ? "Positive" : (num < 0) ? "Negative" : "Zero";
            Console.WriteLine(result);
        }
    }
}
