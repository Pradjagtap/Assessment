using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    //write a code to display number between 1 to 50 at the time of displaying if number is divisible by 3 then display pune
    //if number is divisible by 5 then display welcome and if divisible by both then display welcome to pune.
    public class DivisibilityusingLoop
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to Pune");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Pune");
                }
                else if( i % 5 == 0)
                {
                    Console.WriteLine("Welcome");
                }
               else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
