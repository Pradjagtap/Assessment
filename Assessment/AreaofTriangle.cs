using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class AreaofTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base: ");
            Double base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            Double height = Convert.ToDouble(Console.ReadLine());

            Double area = 0.5 * (base1 * height);

            Console.WriteLine("Area of triangle is: " + area);
        }
    }
}
