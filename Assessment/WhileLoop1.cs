using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class WhileLoop1
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number:");
            int m = Convert.ToInt32(Console.ReadLine());

            {
                while (n <= m)
                {
                    Console.WriteLine(n);
                    n++;
                }
            }
        }
    }
    }
