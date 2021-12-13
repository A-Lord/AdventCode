using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;


namespace AdventCode_main.Day7
{
    public class Day7
    {
        private int[] crabCords;
        private int _part;
        private Dictionary<int,int> theData = new Dictionary<int, int>();
        public Day7(int part, bool test)
        {
            _part = part;
            crabCords = GetInput(test);

            CalculateBestLine();

        }
        private void CalculateBestLine()
        {
            
            foreach (var item in crabCords)
            {
                int fuelCost = 0;
                
                for (int i = 0; i < crabCords.Max(); i++)
                {
                    int bigOrSmall = item == i ? 0 : item > i ? -1 : 1;  
                    switch (bigOrSmall)
                    {
                        case 0:
                            fuelCost = 0;
                            break;
                            case -1:
                            fuelCost = FuelCount(item - i);
                            break;
                            case 1:
                            fuelCost = FuelCount(i - item);
                            break;
                        default:
                            break;
                    }

                    if (theData.ContainsKey(i))
                    {
                        theData[i] += fuelCost;
                    }
                    else
                    {
                          theData.Add(i,fuelCost);
                    }
                }
       
            }
            int BestLine = theData.MinBy(x => x.Value).Key;
            System.Console.WriteLine(theData[BestLine]);
            System.Console.WriteLine(BestLine);
            System.Console.WriteLine(theData[5]);

        }
        private int FuelCount(int fuelCost)
        {
            if (_part == 2)
            {
                int expoNr = 1; 
                int counter = fuelCost;   
                fuelCost = 0;                     
                for (int i = 0; i < counter; i++)
                {
                    fuelCost += expoNr;
                    expoNr++;
                }
            }
            return fuelCost;
        }
        private int[] GetInput(bool test)
        {

                if(test)
                {
                    foreach (string line in File.ReadAllLines(@"/home/sildor/Documents/AdventCode-main/Day7/crabsTest.txt"))
                    {               
                    int[] crabCordsTest = Regex.Split(line, @"[^\d]+").Select(int.Parse).ToArray();
                    return crabCordsTest;
                    }
                }
                else
                {
                      foreach (string line in File.ReadAllLines(@"/home/sildor/Documents/AdventCode-main/Day7/crapsLive.txt"))
                    {               
                    int[] crabCordsTest = Regex.Split(line, @"[^\d]+").Select(int.Parse).ToArray();
                    return crabCordsTest;
                    }
                }
                int[] bug = new int[1];
                return bug;
        }
    }
}