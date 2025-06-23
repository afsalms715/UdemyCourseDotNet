using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    public class SecondsToMinutes
    {
        public string ConvertSecondsToMinutes(int seconds)
        {
            int numberOfSeconds = seconds % 60;
            int numberOfMinutes = seconds / 60;
            int numberOfHours = numberOfMinutes / 60;
            int numberOfDays = numberOfHours / 24;
            return $"{numberOfDays} days {numberOfHours} hours {numberOfMinutes} minutes {numberOfSeconds} seconds";
        }
    }
}
