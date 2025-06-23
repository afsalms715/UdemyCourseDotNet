using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    public class HeightCategory
    {
        public string GetHeightCategory(double heightInInches)
        {
            double heightInCentimeter = heightInInches * 2.54;
            if (heightInCentimeter <= 150)
            {
                return "Dwarf";
            }
            else if (heightInCentimeter > 150 && heightInCentimeter <= 165)
            {
                return "Average height";
            }
            else if (heightInCentimeter > 165 && heightInCentimeter <= 195)
            {
                return "Tall";
            }
            else
            {
                return "Abnormal height";
            }
        }
    }
}
