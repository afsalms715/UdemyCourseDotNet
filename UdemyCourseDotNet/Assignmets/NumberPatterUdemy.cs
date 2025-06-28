using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourseDotNet.Assignmets
{
    /*   1 2 3 4 7 8 9 10
         1 2 3 4 7 8 9 10
         1 2 3 4 7 8 9 10
         10 9 8 7 6 5 4 3 2 1
         10 9 8 7 6 5 4 3 2 1
         10 9 8 7 6 5 4 3
         10 9 8 7 6 5 4 3 2 1
         1 2 3 4 5 6 7 9 10    */ //this is the pattern 
    /*
     1
     */
    public class NumberPatterUdemy
    {
        public void PrintPattern()
        {
            for (int i = 1; i <= 8; i++)
            {
                int k = 10;
                for (int j = 1; j <= 10; j++)
                {
                    if (i <= 3)
                    {
                        if (j == 5 || j == 6) continue;
                        Console.Write(j + " ");
                    }
                    else if (i == 4 || i == 5 || i == 7)
                    {
                        Console.Write(k + " ");
                        k--;
                    }
                    else if (i == 6)
                    {
                        if (j == 9 || j == 10) continue;
                        Console.Write(k + " ");
                        k--;
                    }
                    else
                    {
                        if (j == 8) continue;
                        Console.Write(j + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
