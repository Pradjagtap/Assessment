using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Krishnamurthi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
                
            int temp, sum = 0, rem;
            temp = num;
            while (num > 0)
            {
                int fact = 1;
                rem = num % 10;
                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (sum == temp)
            {
                Console.WriteLine("Krisanmurthi number");
            }
            else
            {
                Console.WriteLine("Not krishanmurthi number");

            }
        }

    }
}

