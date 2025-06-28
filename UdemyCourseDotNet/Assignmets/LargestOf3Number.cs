using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    public class LargestOf3Number
    {
        public int FindLargestOf3Number(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The largest number is: " + number1);
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("The largest number is: " + number2);
                return number2;
            }
            else
            {
                Console.WriteLine("The largest number is: " + number3);
                return number3;
            }
        }
    }
}
