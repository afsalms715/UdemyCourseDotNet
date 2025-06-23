using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    public class AreaOfCircle
    {
        public double CalculateAreaOfCircle(int? r)
        {
            int radius = r ?? 0;
            const double pi = 3.14;
            double area = 0;
            if (radius == 0)
            {
            readagain:
                Console.WriteLine("Enter the radius of the circle:");
                try
                {
                    radius = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto readagain;
                }
            }
            area = pi * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
            return area;
        }
    }
}
