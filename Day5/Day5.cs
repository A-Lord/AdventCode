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
            
        }
        public void run()
        {
            int chunkSize = 4;
            Dictionary<int ,Stack<string>> chunks = new Dictionary<int ,Stack<string>>();
            Dictionary<int ,Stack<string>> formatedChunks = new Dictionary<int ,Stack<string>>();

            for (int j = 1; j < 11; j++)
            {
                chunks.Add(j, new Stack<string>());
                formatedChunks.Add(j, new Stack<string>());
            }

            string[] lines = File.ReadAllLines(@"C:\Users\User\git\AdventCode\Day5\input.txt");
            string[] startInput = lines.Take(10).ToArray();
            string[] commands = lines.Skip(10).ToArray();


            for (int j = startInput.Length; j-- > 0;)
            {

                int counter = 1;
                    for (int i = 0; i < startInput[j].Length -1; i += chunkSize)
                    {

                    string block = startInput[j].Substring(i, chunkSize);
                    string test = new String(block.Where(Char.IsLetter).ToString());
                    if (test != null)
                    {
                        chunks[counter].Push(test);
                    }
                    counter++;
                    
                }
                foreach (var item in chunks)
                {
                    foreach (var x in item.Value)
                    {
                        Console.Write(x + ",");
                    }
                }
                



            }
               
            


            
            

        }
    }
}
