using System;
using System.IO;
using System.Text;



            Console.WriteLine("Hello, World!");
             var lines = File.ReadAllLines("input.txt");
             int[] ints = Array.ConvertAll(lines, int.Parse);
            int timesItsBigger = 0;
            int lastMeasurment = 0;
             foreach (var item in ints)
             {
                if(lastMeasurment != 0)
                {
                    if(item > lastMeasurment)
                    {
                         timesItsBigger++;
                    }                 
                }
                lastMeasurment = item;
             } 
             Console.WriteLine(timesItsBigger);