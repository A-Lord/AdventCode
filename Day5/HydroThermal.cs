using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventCode.Day5
{
    internal class HydroThermal
    {

        private Grid _grid = new Grid();
        public HydroThermal(int WhichPart)
        {
            
            SplitLines(WhichPart);
        }
        private void SplitLines(int WhichPart)
        {
            foreach (string line in File.ReadAllLines(@"C:\Users\Adam\Source\Repos\A-Lord\AdventCode\Day5\gama.txt"))
            {
                
                int[] coords = Regex.Split(line, @"[^\d]+").Select(int.Parse).ToArray();
                _grid.CountAllX(coords[0], coords[1], coords[2], coords[3]);
     
            }
            _grid.GetAnswer();
        }
    }
}
