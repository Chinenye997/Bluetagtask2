using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetagtask2
{
    class AreaofCircle
    {
        static void Main(string[] args)
        {

            double radius, area;
            Console.WriteLine("Enter the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;

            Console.WriteLine("Area of the circle with radius {0} is {1}", radius, area);

            Console.WriteLine("Press any key to exit");



            Console.ReadLine();

        }
    }
}
