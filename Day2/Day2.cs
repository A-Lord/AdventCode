using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode.Day2
{
    internal class Day2
    {

        public Day2()
        {
            run();
        }
        public void run()
        {

            //Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"C:\Users\sildor\Documents\minaSidor\mina-sidor\AdventCode\Day2\input.txt");
            string[] stringIds = lines[0].Split(",");
            string[] currentString;
            string startID;
            string endId;
            long range;
            string currentNumb;
            long answer = 0;
            for (int i = 0; i < stringIds.Length; i++)
            {
                currentString = stringIds[i].Split('-');
                startID = currentString[0];
                endId = currentString[1];
                range = long.Parse(endId) - long.Parse(startID);
                currentNumb = startID;
                // string first;
                // string second;
                // int halfNumber;
                for (int j = 0; j < range; j++)
                {
                    // if (currentNumb.Length % 2 == 0)
                    // {
                    //     halfNumber = currentNumb.Length / 2;
                    //     first = currentNumb.Substring(0, halfNumber);
                    //     second = currentNumb.Substring(halfNumber);
                    //     if (first == second)
                    //     {
                           
                    //     }
                    // }
                    if (Check(currentNumb))
                    {
                         answer = answer + long.Parse(currentNumb);
                    }

                    currentNumb = (long.Parse(currentNumb) + 1).ToString();

                }
            }


            Console.WriteLine("Day1 Part 2 Answer: :");
            Console.WriteLine(answer);
            Console.WriteLine("");
            Console.WriteLine("Day1 Part 2 Answer: :");
        }

        public bool Check(string str)
        {
            return (str + str).IndexOf(str, 1) != str.Length;
        }









        //Console.WriteLine(similarity);

    }

}

