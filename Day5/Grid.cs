using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode.Day5
{
    internal class Grid
    {
        //private int[,] grid = new int[10, 10];
        //public int TotalCrossings = 0;
        //public int TotalCrossings2 = 0;
        private Dictionary<(int, int), int> map = new();
        public Grid()
        {
        }
        public void CountAllX(int x1,int y1,int x2,int y2)
        {
            // we are going to use the xstep when we move in the map.
            int xStep = 0;
            int yStep = 0;

            if (x1 == x2)
            {
                xStep = 0;
            }
            if (x1 > x2)
            {
                xStep = -1;
            }
            if (x1 < x2)
            {
                xStep = 1;
            }
            
            if (y1 == y2)
                yStep = 0;
            if (y1 > y2)
            {
                yStep = -1;
            }
            if (y1 < y2)
            {
                yStep = 1;
            }


            //shortend if's that looks nicer.
            //int xStep = x1 == x2 ? 0 : x1 > x2 ? -1 : 1;  
            //int yStep = y1 == y2 ? 0 : y1 > y2 ? -1 : 1;  




            (int x, int y) = (x1, y1);
            do
            {//look if the line crosses any lines before it, if it does add +1 to the value at that key spot.
                if (!map.ContainsKey((x, y)))
                {
                    map[(x, y)] = 0;
                }
                map[(x, y)]++;
                if ((x, y) == (x2, y2))
                {
                    break;
                }// xstep and ystep changes if depending on what direction the line is at untill it hits the x2 and y2 then it breaks and we go to the next line.
                x += xStep; 
                y += yStep;
            } while (true);
        }

        public void GetAnswer()
        {
            string output = map.Count(p => p.Value > 1).ToString(); //we count all the times the value in any key is more then 1 .
            Console.WriteLine(output);
        }

        //public void AddLine(string[] xys)
        //{
        //    int firstX = Convert.ToInt32(xys[0]);
        //    int firstY = Convert.ToInt32(xys[1]);
        //    int lastX = Convert.ToInt32(xys[2]);
        //    int lastY = Convert.ToInt32(xys[3]);


        //    int x1 = firstX;
        //    int x2 = lastX;
        //    int y1 = firstY;
        //    int y2 = lastY;
        //    Console.WriteLine($"{firstX} {firstY}  ---  {lastX} {lastY}");

        //    if (firstX == lastX)
        //    {
        //        if (firstY > lastY)
        //        {
        //            for (int i = lastY; i < firstY + 1; i++)
        //            {
        //                grid[firstX, i] += 1;
        //                if (grid[firstX, i] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //            }
        //        }
        //        if (firstY < lastY)
        //        {
        //            for (int i = firstY; i < lastY + 1; i++)
        //            {
        //                grid[firstX, i] += 1;
        //                if (grid[firstX, i] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //            }
        //        }
        //    }
        //    else if (firstY == lastY)
        //    {
        //        if (firstX > lastX)
        //        {
        //            for (int i = lastX; i < firstX + 1; i++)
        //            {
        //                grid[i, lastY] += 1;
        //                if (grid[i, lastY] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //            }
        //        }
        //        if (firstX < lastX)
        //        {
        //            for (int i = firstX; i < lastX + 1; i++)
        //            {
        //                grid[i, lastY] += 1;
        //                if (grid[i, lastY] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {


        //        //double answer = Math.Atan2(y2 - y1, x2 - x1);
        //        //double degrees = (180 / Math.PI) * answer;


        //        float slope = (y2 - y1) / (x2 - x1);



        //        float xDiff = x2 - x1;
        //        float yDiff = y2 - y1;

        //        var test = Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        //        Console.WriteLine($"{test} slope: {slope}");

        //        if (test == 135)
        //        {
        //            for (int i = x1; i > x2 -1; i--)
        //            {
        //                grid[i, y1] += 1;
        //                if (grid[i, y1] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //                y1++;

        //            }
        //        }
        //        else if (test == -135)
        //        {

        //            for (int i = x1; i > x2 - 1; i--)
        //            {
        //                grid[i, y1] += 1;
        //                if (grid[i, y1] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //                y1--;

        //            }
        //        }
        //        else if(test == 45)
        //        {
        //            for (int i = x1; i < x2 +1; i++)
        //            {

        //                grid[i, y1] += 1;
        //                if (grid[i, y1] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //                y1++;

        //            }


        //        }
        //        else if (test == -45)
        //        {
        //            for (int i = y1; i < y2 + 1; i++)
        //            {
        //                grid[x1, i] += 1;
        //                if (grid[x1, i] == 2)
        //                {
        //                    TotalCrossings += 1;
        //                }
        //                x1--;
        //            }


        //        }


        //    }


        //}

    }
}
