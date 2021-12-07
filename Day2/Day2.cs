using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class Day2
    {
        string[] lines = File.ReadAllLines(@"C:\Users\sildo\AdventCode\navigation.txt");
        public Day2()
        {
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;
            foreach (var item in lines)
            {
                string[] command = item.Split(' ');
                switch (command[0])
                {
                    case "forward":
                        horizontalPosition += Convert.ToInt32(command[1]);
                        depth += (aim * Convert.ToInt32(command[1]));
                        break;
                    case "down":
                        //depth += Convert.ToInt32(command[1]);
                        aim += Convert.ToInt32(command[1]);
                        break;
                    case "up":
                        //depth -= Convert.ToInt32(command[1]);
                        aim -= Convert.ToInt32(command[1]);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(horizontalPosition * depth);
        }
        
    }
}
