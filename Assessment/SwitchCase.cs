using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to my Cafe----");
            Console.WriteLine("1.Tea\n2.Coffee\n3.Cold drinks\n");
            Console.WriteLine("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Tea is Rs 30");
                    break;
                case 2:
                    Console.WriteLine("Coffee is Rs 100");
                    break;
                case 3:
                    Console.WriteLine("Cold drink Rs 50");
                    break;
                //default:
                  //  Console.WriteLine("invalid choice");

            }
        }
    }
}
