using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class Boards
    {
        bool hasWon = false;
        private string[,] array2D = new string[,] 
        { 
            { "A", "A", "A", "A", "A", },
            { "A", "A", "A", "A", "A", },
            { "A", "A", "A", "A", "A", },
            { "A", "A", "A", "A", "A", },
            { "A", "A", "A", "A", "A", }, 
        };

        public int _id;
        public Boards(List<string> inputs,int boardNr)
        {
            _id = boardNr;
            int j = 0;
            foreach (var numberLists in inputs)
            {
                string[] tempString = numberLists.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < 5; i++)
                {
                    array2D[j,i] = tempString[i];
                }
                j++;
            }

        }
   
        public void AddNumber(string a)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array2D[i,j] == a)
                    {
                        array2D[i,j] = "X";
                        if (array2D[i, 0] == "X" && array2D[i, 1] == "X" && array2D[i, 2] == "X" && array2D[i, 3] == "X" && array2D[i, 4] == "X" && hasWon == false)
                        {
                            int answer = 0;
                            Console.WriteLine($"{_id} won on number {a}");
                            foreach (var item in array2D)
                            {
                                if (item != "X")
                                {
                                    answer = answer + Convert.ToInt32(item);
                                }
                            }

                            Console.WriteLine(Convert.ToInt32(a) * answer);
                            hasWon = true;
                        }
                        if (array2D[0, j] == "X" && array2D[1, j] == "X" && array2D[2, j] == "X" && array2D[3, j] == "X" && array2D[4, j] == "X" && hasWon == false)
                        {
                            int answer = 0;
                            Console.WriteLine($"{_id} won on number {a}");
                            foreach (var item in array2D)
                            {
                                if (item != "X")
                                {
                                    answer = answer + Convert.ToInt32(item);
                                }
                            }
                            hasWon = true;

                            Console.WriteLine(Convert.ToInt32(a) * answer);
                        }
                    }
                }
            }
            
        }
        
        

    }
}
