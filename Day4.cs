using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class Day4
    {
        public Day4()
        {
            ReadBingoBoards();
        }


        private void ReadBingoBoards()
        {
            List<string> bingoiNoSpace = new List<string>();
            string[] bingoBoards = File.ReadAllLines(@"C:\Users\sildo\AdventCode\bingo.txt");
            var numbers = bingoBoards[0].Split(',').ToList();
            bool firstLine = true;
            foreach (string bingoBoard in bingoBoards)
            {
                if (firstLine)
                {
                    firstLine = false;
                    Console.WriteLine("true");
                }
                else if (bingoBoard != null)
                {
                    bingoiNoSpace.Add(bingoBoard);

                }
               
            }
           


            Dictionary<int,List<string>> keyValuePairs = new Dictionary<int,List<string>>();


            int boardCounter = 1;
            int boardRows = 0;

            for (int i = 1; i < bingoiNoSpace.Count; i++)
            {
                if (boardRows < 5)
                {
                    if (boardRows == 0)
                    {
                        keyValuePairs.Add(boardCounter, new List<string>());

                    }
                    keyValuePairs[boardCounter].Add(bingoiNoSpace[i]);
                    boardRows++;
                }

                else if (boardRows == 5)
                {
                    boardRows = 0;
                    boardCounter++;
                }
                    
                
               
            }
            List<Boards> boards = new List<Boards>();
            foreach (var item in keyValuePairs)
            {
                boards.Add(new Boards(item.Value, item.Key));
            }
           
            foreach (var item in numbers)
            {
                for (int i = 0; i < boards.Count; i++)
                {
                    boards[i].AddNumber(item);
                }

            }
            




        }
    }
}
