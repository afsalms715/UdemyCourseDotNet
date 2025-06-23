using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    internal class NearestThousand
    {
        public int GetNearestThousand(int number)
        {
            int noOfThousand = number / 1000;
            if (noOfThousand <= 0) return 1000;
            else
            {
                int mod = number % 1000;
                if (mod >= 500)
                {
                    return noOfThousand * 1000 + 1000;
                }
                else
                {
                    return noOfThousand * 1000;
                }
            }
        }
    }
}
