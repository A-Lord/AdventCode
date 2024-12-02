using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode.Day1
{
    internal class Day1
    {

        public Day1()
        {
            run();
        }
        public void run()
        {

            //Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day1\input.txt");
            int[] leftSide = new int[lines.Length];
            int[] rightSide = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {

                string[] splitLine = lines[i].Split("   ");
               
                leftSide[i] = Int32.Parse(splitLine[0]);
                rightSide[i] = Int32.Parse(splitLine[1]);



            }
            Array.Sort(leftSide);
            Array.Sort(rightSide);

            int distance = 0;
            int testDistance = 0;
            int similarity = 0;
            int similarityMultiplier = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                similarityMultiplier = 0;
                for (int x = 0; x < lines.Length; x++)
                {
                    if (leftSide[i] == rightSide[x])
                        similarityMultiplier += 1;
                }
                similarity += leftSide[i] * similarityMultiplier;

                if (leftSide[i] >= rightSide[i])
                    testDistance = leftSide[i] - rightSide[i];
                if(rightSide[i] > leftSide[i])
                    testDistance = rightSide[i] - leftSide[i];
               
                distance += testDistance;
            }
       

            Console.WriteLine("Day1 Part 1 Answer: :");
            Console.WriteLine(distance);
            Console.WriteLine("Day1 Part 2 Answer: :");
            Console.WriteLine(similarity);

        }
    
    }
}
