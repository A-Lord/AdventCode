using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode
{
    internal class Day8
    {
        private List<string[]> _segmentClockList = new List<string[]>();
        private List<string[]> _segmentClockInputs = new List<string[]>();
        private string[] inputSorter = new string[10];
        
           
        public Day8()
        {
            
        //first part , find 1,4,7,8
        //0 = 4xA 2xB 2xC 2xE 2xF 4xG
        //1 = 2xA 2xF
        //2 = 4xA 2xC 4xD 2xE 4xG
        //3 = 4xA 2xC 4xD 2xF 4xG
        //4 = 2xB 2xC 4xD 2xf
        //5 = 4xA 2xB 4xD 2xF 4xG
        //6 = 4xA 2xB 4xD 2xE 2xF 4xG
        //7 = 4xA 2xC 2xF
        //8 = 4xA 2xB 2xC 4xD 2xE 2xf 4xG
        //9 = 4xA 2xB 2xC 4xD 2xF 4xG

    //vilka behöver 4 av ett nummer = 0,2 3,3 4,1 5,3 6,3 7,1 8,3 9,3
    //  Ax4 = 0,1,2,3,5,6,7,8,9
    //  Dx4 = 2,3,5,6,8,9
    //  Gx4 = 0,2,3,5,6,8,9

    // Bx2 = 0,5,6,8,9
    // Cx2 = 0,2,3,4,7,8,9
    // Ex2 = 0,2,6,8
    // Fx2 = 0,1,3,4,5,6,7,8,9


//  dddd
// e    a
// e    a
//  ffff
// g    b
// g    b
//  cccc        
        }
        private void ReadInput(int part,bool test)
        {
            if (test)
            {
                
                        _segmentClockList.Clear();
            
            foreach (string line in File.ReadAllLines(@"Day8\InputTest.txt"))
                    {
                        
                        string[] segmentCLock = line.Split('|');
                        
                    _segmentClockInputs.Add(segmentCLock);
                    
                    }
            }
            else
            {
                _segmentClockList.Clear();
                    foreach (string line in File.ReadAllLines(@"Day8\Input.txt"))
                    {
                        
                        string[] segmentCLock = line.Split('|');
                        _segmentClockInputs.Add(segmentCLock);
                    }
            }
        }

        private string SortString(string input)
        {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
        }
        public int CalculateDigits(int part,bool test)
        {  
            int counter = 0;
            int TheDigitAnswer = 0;
            string intAdder = "";
            List<int> ActualDigits = new List<int>();
                ReadInput(part,test);
                
                foreach (var item in _segmentClockInputs)
                {
                    char[] solvedArray = new char[7];
                    string[] splitedStringIn = item[0].Split(' ');
                    string[] splitedString = item[1].Split(' ');
                    
                    for (int i = 0; i < splitedStringIn.Length; i++)
                    {
                        splitedStringIn[i] = SortString(splitedStringIn[i]);
                    }
                    Dictionary<char, int> dict = new Dictionary<char, int>();
                    foreach (var stringen in splitedStringIn)
                    {
                        foreach (char ch in stringen)
                        {
                            if (dict.ContainsKey(ch))
                            {
                                dict[ch] = dict[ch] + 1;
                            }
                            else
                            {
                                dict.Add(ch, 1);
                            }
                        }
                    }
                    
                    
                    
                   
                  
                    
                    solvedArray[4] = dict.First(x => x.Value == 4).Key;
                    string[] theOddOnes = new string[3];
                    
                    

                    intAdder = "";
                    string[] sixDigits = new string[3];
                    foreach (var a in splitedString)
                    {
                        int dL = a.Length;
                        string TheDigit = "";
                         //int TheDigit = dL == 2 ? 1 : dL == 4 ? 4 : dL == 3 ? 7 : dL == 7 ? 8 : 100;
                        
                        if (dL == 2)
                        {
                            TheDigit = "1";
                        }
                        if (dL == 4)
                        {
                            TheDigit = "4";
                        }
                        if (dL == 3)
                        {
                            TheDigit = "7";
                        }
                        if (dL == 7)
                        {
                            TheDigit = "8";
                        }


                            
                        
                        if (dL == 6)
                        {
                            if (a.Contains(solvedArray[4]))
                            {
                                int countToZero = 0;
                                foreach (char ch in a)
                                {
                                    foreach (var Answer in dict)
                                    {
                                        if (ch == Answer.Key)
                                        {
                                            if (Answer.Value == 7)
                                            {
                                                countToZero++;
                                            }
                                        }
                                    }
                                }
                                if (countToZero == 2)
                                {
                                    TheDigit = "6";
                                }
                                else
                                {
                                    TheDigit = "0";
                                }
                            }
                            else
                            {
                                TheDigit = "9";
                            }
                             
                        }
                        if (dL == 5)
                        {
                            if (a.Contains(solvedArray[4]))
                            {
                            TheDigit = "2";
                            }
                            else if (a.Contains(solvedArray[1]))
                            {
                                TheDigit = "5";
                            }
                            else
                            {
                                TheDigit = "3";
                            }
                        }
                        
                            intAdder += TheDigit;
                        
                        
                    }
                    


                    System.Console.WriteLine(intAdder);
                    TheDigitAnswer = Convert.ToInt32(intAdder);
                    counter += TheDigitAnswer;
                    intAdder = "";
                    // foreach(var x in splitedString)
                    // {
                    //     int dL = x.Length;
                    //     int TheDigit = dL == 2 ? 1 : dL == 4 ? 4 : dL == 3 ? 7 : dL == 7 ? 8 : 10;
                    //     if (TheDigit != 10)
                    //     {
                    //         counter++;

                    //     }

                    //     //Önskelista
                    // }
                                             
             
                   
                    //int xStep = x1 == x2 ? 0 : x1 > x2 ? -1 : 1;
                }
                
                return counter;
        }

    //vilka behöver 4 av ett nummer = 0,2 3,3 4,1 5,3 6,3 7,1 8,3 9,3
    //  Ax4 = 0,3,5,6,7,8,9
    //  Dx4 = 3,5,6,8,9
    //  Gx4 = 0,3,5,6,8,9

    // Bx2 = 0,5,6,8,9
    // Cx2 = 0,3,4,7,8,9
    // Ex2 = 0,6,8
    // Fx2 = 0,1,3,4,5,6,7,8,9
    




    
        //1 = 2 + 2 = 4
        //4 = 2 + 2 + 4 + 2 = 10 
        //7 = 4 + 2 + 2 = 8
        //8 = 4 + 2 + 2 + 4 + 2 + 2 + 4 = 20




    }
}