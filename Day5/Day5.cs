using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode.Day5
{
    internal class Day5
    {
        public Day5()
        {
            run();
        }
        public void run()
        {
            Dictionary<int ,Stack<char>> chunks = new Dictionary<int ,Stack<char>>();
            string[] lines = File.ReadAllLines(@"F:\Work\AdventCode\Day5\input.txt");
            string[] startInput = lines.Take(8).ToArray();
            string[] commands = lines.Skip(10).ToArray();
            for (int i = startInput.Length; i-- > 0;)
            {
                string test = startInput[i].Replace("    ", "[X] ").Replace("   ", "[x]");
                Regex rgx = new Regex("[^a-zA-Z-]");
               test = rgx.Replace(test, "");
                for (int j = 0; j < test.Length; j++)
                {
                    if(test[j] != 'X')
                    {
                        int index = j + 1;
                        if (!chunks.ContainsKey(index))
                            chunks.Add(index, new Stack<char>());
                        chunks[index].Push(test[j]);
                    }
                }       
            }
            Stack<char> crane = new Stack<char>();
            foreach (var c in commands)
            {
                var coms = c.Split(' ');
                for (int i = 0; i < Int32.Parse(coms[1]); i++)
                {
                    crane.Push(chunks[Int32.Parse(coms[3])].Pop());
                }
                for (int i = 0; i < Int32.Parse(coms[1]); i++)
                {
                    chunks[Int32.Parse(coms[5])].Push(crane.Pop());
                }
            }
            Console.WriteLine("Day5 Answer: ");
            foreach (var item in chunks)
            {
                Console.Write(item.Value.Peek());
            }
        }
    }
}
