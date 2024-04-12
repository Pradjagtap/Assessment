using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class FirstProgram
    {
        //main is not public method
        //Main () M is in capital letter
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"Addition is {c}");

        }
    }
}
