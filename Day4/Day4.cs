using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode.Day4
{
    internal class Day4
    {

        public Day4()
        {
            run();
        }
        public void run()
        {

            //Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day4\input.txt");
            int firstNumber = 0;
            int secondNumber = 0;
            int finalResult = 0;
            bool wasLastAdo = true;
            for (int i = 0; i < lines.Length; i++)
            {


                
                MatchCollection matches = Regex.Matches(lines[i], @"don't\(\)|mul\(\d+\,\d+\)|do\(\)");

                foreach (Match match in matches)
                {
                    string parsedMatch = match.Value;
                    if (parsedMatch == "don't()") {
                        wasLastAdo = false;
                    }
                    else if (parsedMatch == "do()")
                    {
                        wasLastAdo = true;
                    }
                    else if (wasLastAdo)
                    {
                        string[] splitLine2 = parsedMatch.Split(',');
                        firstNumber = int.Parse(Regex.Replace(splitLine2[0], "[^0-9 _]", ""));
                        secondNumber = int.Parse(Regex.Replace(splitLine2[1], "[^0-9 _]", ""));
                        finalResult = finalResult + (firstNumber * secondNumber);
                    }
                  
                }

            }
    

       

            Console.WriteLine("Day3 Part 1 Answer: :");
            Console.WriteLine(finalResult);

            Console.WriteLine("Day3 Part 2 Answer: :");
            //Console.WriteLine(similarity);

        }
    
    }
}
