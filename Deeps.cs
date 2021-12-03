 using System;
using System.IO;
using System.Text;

namespace AdventCode
{
    class Deeps
    {
            public Deeps()
            {

            string[] lines = File.ReadAllLines("input.txt");
            int[] ints = Array.ConvertAll(lines, int.Parse);
            int timesItsBigger = 0;
            int lastMeasurment = 0;
            int lastThreeSum = 0;

             List<int> threeSums = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                lastMeasurment = 0;
                if (i >= ints.Length - 2)
                {
                    break;
                }
                for (int j = 0; j < 3; j++)
                {
                    lastMeasurment += ints[i+j];
                }
                if (i != 0)
                {
                        if (lastMeasurment > lastThreeSum)
                        {
                            timesItsBigger++;
                        }                        
                }
                lastThreeSum = lastMeasurment;
            }

            Console.WriteLine(timesItsBigger);
            //  foreach (var item in ints)
            //  {
            //     if(lastMeasurment != 0)
            //     {
                     
            //     }
            //     lastMeasurment = item;
            //  } 
            //  Console.WriteLine(timesItsBigger

            }
           
    }
}

 
 