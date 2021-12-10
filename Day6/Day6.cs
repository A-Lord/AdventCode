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
        private List<int> fishList = new List<int>();
        private Dictionary<BigInteger,Fish> fishListSmart = new Dictionary<BigInteger, Fish>();
        private long[] fishDays = new long[9];
        
        public Day6()
        {   
            int index = 0;
            foreach (string line in File.ReadAllLines(@"C:\Users\Adam\Source\Repos\A-Lord\AdventCode\Day6\fish.txt"))
            {
                
                int[] fishes = Regex.Split(line, @"[^\d]+").Select(int.Parse).ToArray();
                
                foreach (var item in fishes)
                {
                    switch (item)
                    {
                        case 0:
                            fishDays[0]++;
                            break;
                        case 1:
                            fishDays[1]++;
                            break;
                        case 2:
                            fishDays[2]++;
                            break;
                        case 3:
                            fishDays[3]++;
                            break;
                        case 4:
                            fishDays[4]++;
                            break;
                        case 5:
                            fishDays[5]++;
                            break;
                        case 6:
                            fishDays[6]++;
                            break;
                        case 7:
                            fishDays[7]++;
                            break;
                        case 8:
                            fishDays[8]++;
                            break;

                        default:
                            break;
                    }

                    //fishList.Add(new Fish(item));
                }
            }
            FishSex();
        }

        public void FishSex()
        {
            int days = 256;
            long fishBirths;
            while (days > 0)
            {
                fishBirths = fishDays[0];
                for (int i = 0; i < fishDays.Length -1; i++)
                {
                    fishDays[i] = fishDays[i + 1];
                }
                fishDays[8] = fishBirths;
                fishDays[6] += fishBirths;
                days--;
            }
            long sum = fishDays.Sum();
            Console.WriteLine(sum);
            //int days = 0;
            //BigInteger AmpintOfFish = index;
            //BigInteger fishCounter = 0;
            //while (true)
            //{
            //    days++;
            //    BigInteger bigCounter = AmpintOfFish;
            //    fishCounter = 0;

            //    while (fishCounter != bigCounter)
            //    {
            //        if(fishListSmart[fishCounter].AgeUp())
            //        {
            //            fishListSmart.Add(AmpintOfFish,new Fish());
            //            AmpintOfFish++;
            //        }
            //        fishCounter++;
            //    }
                
            //    if (days == 256)
            //    {
            //        System.Console.WriteLine(AmpintOfFish);
            //        break;
            //    }
            //    Console.WriteLine(days);

            //}
            //Console.ReadKey();
        }
    }
}
