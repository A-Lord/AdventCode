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
        
        public Day6()
        {   
            int index = 0;
            foreach (string line in File.ReadAllLines(@"/home/sildor/Documents/AdventCode-main/Day6/fish.txt"))
            {
                
                int[] fishes = Regex.Split(line, @"[^\d]+").Select(int.Parse).ToArray();
                
                foreach (var item in fishes)
                {
                    fishListSmart.Add(index,new Fish(item));
                    index++;
                    //fishList.Add(new Fish(item));
                }
            }
            FishSex(index);
        }

        public void FishSex(int index)
        {
            int days = 0;
            BigInteger AmpintOfFish = index;
            BigInteger fishCounter = 0;
            while (true)
            {
                days++;
                

                while (fishCounter < AmpintOfFish)
                {
                    if(fishListSmart[fishCounter].AgeUp())
                    {
                        AmpintOfFish++;
                        fishListSmart.Add(AmpintOfFish,new Fish());
                    }
                }
                if(days == 45)
                {
                    System.Console.WriteLine(AmpintOfFish);
                }

            }
        }
    }
}
