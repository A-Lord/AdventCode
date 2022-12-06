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
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day6\input.txt");
            string markers = "";
            for (int i = 0; i < lines[0].Length; i++)
            {
               
                if (i > 2 && i < (lines[0].Length - 3))
                {
                    int startIndex = i - 3;

                    var lastFor = lines[0].Substring(startIndex, 4).ToList();
                    var results = lastFor.Distinct();
                    Console.WriteLine(results.Count());
                    if (results.Count() == 4)
                    {
                        markers += i+1;
                    }
                }
            }
            //Console.WriteLine(markers);
        }

       
        
    }
}
