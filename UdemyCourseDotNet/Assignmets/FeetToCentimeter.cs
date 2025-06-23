using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    public class FeetToCentimeter
    {

        public double ConvertFeetToCentimeter(double? feet)
        {
            string input = feet?.ToString() ?? "";
            while (string.IsNullOrEmpty(input) || !double.TryParse(input, out _))
            {
                Console.WriteLine("Enter the Height in feet & inches eg: 5.7");
                input = Console.ReadLine();
            }
            string[] parts = input.Trim().Split(".");
            int feetPart = Convert.ToInt32(parts[0]);
            int inchesPart = parts.Length > 1 ? Convert.ToInt32(parts[1]) : 0;
            double heightInCentimeter = (feetPart * 30.48) + (inchesPart * 2.54);
            Console.WriteLine("The height in centimeter is: " + heightInCentimeter);
            return heightInCentimeter;
        }

        /* old version
         double heightInCentimeter = 0;
            string heightInFeetAndInches = feet?.ToString() ?? "";
            if (string.IsNullOrEmpty(heightInFeetAndInches))
            {
            readagain:
                try
                {
                    Console.WriteLine("Enter the height in feet and inches:");
                    heightInFeetAndInches = Console.ReadLine();
                    Convert.ToDouble(heightInFeetAndInches);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto readagain;
                }
            }
            var feetAndInches = heightInFeetAndInches.Split('.');
            int feetPart = Convert.ToInt32(feetAndInches[0]);
            int inchesPart = Convert.ToInt32(feetAndInches[1]);
            double feetInCentimeter = feetPart * 30.48;
            double inchesInCentimeter = inchesPart * 2.54;
            heightInCentimeter = feetInCentimeter + inchesInCentimeter;
            Console.WriteLine("The height in centimeter is: " + heightInCentimeter);
            return heightInCentimeter;
         */
    }
}
