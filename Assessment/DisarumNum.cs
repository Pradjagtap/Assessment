using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DisarumNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0, temp, count = 0;
            temp = num;
            while (temp > 0)
            {
                int rem = temp % 10;
                count++;
                temp = temp / 10;

            }
            int disrum = num;
            while (num > 0)
            {
                int x = 1;
                int rem = num % 10;
                for (int i = 1; i <= count; i++)
                {
                    x = rem * x;
                }
                Console.WriteLine(x);
                sum = sum + x;
                num = num / 10;
                count--;
            }
            if (disrum == sum)
            {
                Console.WriteLine("disarum number");
            }
            else
            {
                Console.WriteLine("not disarum number");

            }
        }
    }
}
