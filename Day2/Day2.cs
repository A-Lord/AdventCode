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
    internal class Day3
    {

        public Day3()
        {
            run();
        }
        public void run()
        {

            //Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day2\input.txt");

            int saveReports = 0;
            int testWrongNumbers = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                int lastNumber = 0;
                int curentNumber = 0;
                int isIncreasing = 0;
                Boolean tolerateOne = true;
                
                string[] splitLine = lines[i].Split(" ");
                for (int x = 0; x < splitLine.Length; x++)
                {
                    curentNumber = Int32.Parse(splitLine[x]);
                    if (x == 0)
                    {
                        lastNumber = curentNumber;
                    }
                    else
                    {
                        if(lastNumber < curentNumber)
                        {
                            
                            if((isIncreasing == 0 | isIncreasing == 2) && (curentNumber - lastNumber) <= 3) {
                                isIncreasing = 2;
                                lastNumber = curentNumber;
                            }
                            else if (tolerateOne)
                            {
                                tolerateOne = false;
                                isIncreasing = 2;
                                lastNumber = curentNumber;
                            }
                            else
                            {
                                break;
                            }
                            
                        }
                        else if (lastNumber > curentNumber)
                        {
                            if ((isIncreasing == 0 | isIncreasing == 3) && ((lastNumber - curentNumber) <= 3))
                            {
                                isIncreasing = 3;
                                lastNumber = curentNumber;
                            }
                            else if (tolerateOne)
                            {
                                tolerateOne = false;
                                isIncreasing = 3;
                                lastNumber = curentNumber;
                            }
                            else
                            {
                                break;
                            }

                        }
                        else if (lastNumber == curentNumber && tolerateOne)
                        {
                            lastNumber = curentNumber;
                            tolerateOne = false;
                        }
                        else { break; }

                        if (x == splitLine.Length -1)
                        {
                            saveReports++;
                        }

                    }
     


                }


            }
    

       

            Console.WriteLine("Day1 Part 2 Answer: :");
            Console.WriteLine(saveReports);
            Console.WriteLine(testWrongNumbers);
            Console.WriteLine("Day1 Part 2 Answer: :");
            //Console.WriteLine(similarity);

        }
    
    }
}
