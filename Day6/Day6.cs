using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace AdventCode_main.Day6

{
    internal class Day6
    {
   

        private long[] fishDays = new long[9];        
        public Day6()
        {
            test(4);
            test(14);
        }
        private void test(int uniqNumber)
        {
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day6\input.txt");
            string markers = "";
            for (int i = 0; i < (lines[0].Length + 1); i++)
            {

                if (i > (uniqNumber - 1))
                {
                    int startIndex = i - uniqNumber;

                    var lastFor = lines[0].Substring(startIndex, uniqNumber).ToList();
                    var results = lastFor.Distinct();
                    if (results.Count() == uniqNumber)
                    {
                        markers += " Break at " + i + " and uniqNumber = " + uniqNumber;
                        break;
                    }
                }
            }
            Console.WriteLine(markers);
        }

       
        
    }
}
