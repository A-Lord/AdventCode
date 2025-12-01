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
        private int currentDialerLocation = 50;
        private int amountOfZeroes = 0;
        public Day1()
        {
            run();
        }
        public void run()
        {

            //Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"C:\Users\sildor\Documents\minaSidor\mina-sidor\AdventCode\Day1\input.txt");
            int rotationAmount = 0;
            char rotationDirection;

            for (int i = 0; i < lines.Length; i++)
            {

                rotationDirection = lines[i][0];

                rotationAmount = Int32.Parse(Regex.Replace(lines[i], @"[^\d]", ""));
                switch (rotationDirection)
                {
                    case 'L':
                        getLeftDiale(rotationAmount);
                        break;
                    case 'R':
                        getRightDiale(rotationAmount);
                        break;
                }

            }


            Console.WriteLine("Day1 Part 1 Answer: :");
            Console.WriteLine(amountOfZeroes);
            Console.WriteLine("Day1 Part 2 Answer: :");
            Console.WriteLine("");

        }
        private void getLeftDiale(int rotation)
        {
            while(rotation > 0)
            {
                if (currentDialerLocation == 0)
                {
                    currentDialerLocation = 99;
                    rotation--;
                    
                }
                else
                {
                    currentDialerLocation--;
                    rotation--;
                    if(currentDialerLocation == 0)
                    {
                        amountOfZeroes++;
                    }
                }
               
                
            }
            // int tomany;
            // int tempPosition = currentDialerLocation;
            // if ((tempPosition - rotation) < 0)
            // {
            //     tomany = rotation - tempPosition;
            //     while (tomany > 99)
            //     {
            //         tomany = 100 - tomany;
            //     }
            //     currentDialerLocation = 100 - tomany;
            //     Console.WriteLine("left rotate: " + rotation + " from current: " + tempPosition + " after rotate " + currentDialerLocation);
            //     return;
            // }
            // currentDialerLocation = tempPosition - rotation;
            // Console.WriteLine("left rotate: " + rotation + " from current: " + tempPosition + " after rotate " + currentDialerLocation);
            // return;
        }
        private void getRightDiale(int rotation)
        {
                 while(rotation > 0)
            {
                if (currentDialerLocation == 99)
                {
                    currentDialerLocation = 0;
                    rotation--;
                    amountOfZeroes++;
                }
                else
                {
                    currentDialerLocation++;
                      rotation--;
                }
               
                
            }
            // int tomany;
            // int tempPosition = currentDialerLocation;
            // if ((currentDialerLocation + rotation) > 99)
            // {
            //     tomany = rotation + currentDialerLocation;
            //     while (tomany > 99)
            //     {
            //         tomany = tomany - 99;
            //     }
            //     currentDialerLocation = tomany;
            //     Console.WriteLine("right rotate: " + rotation + " from current: " + tempPosition + " after rotate " + currentDialerLocation);
            //     return;
            // }
            // currentDialerLocation = currentDialerLocation + rotation;
            // Console.WriteLine("right rotate: " + rotation + " from current: " + tempPosition + " after rotate " + currentDialerLocation);
            // return;

        }

    }
}
