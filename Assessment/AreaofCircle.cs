using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
   public class AreaofCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            Double rad = Convert.ToDouble(Console.ReadLine());
            Double pi = 3.14;
            Double area = pi * rad*rad;
            Console.WriteLine("Area of circle is:" + area);

        }
    }
}
