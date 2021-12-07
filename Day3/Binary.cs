namespace AdventCode
{
    internal class Binary
    {
        private readonly string[] lines = File.ReadAllLines(@"C:\Users\Adam\Source\Repos\A-Lord\AdventCode\gama.txt");
        public Binary()
        {
            string finalAnswer = "";
            int[] countedBitsOne = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            int[] countedBitsZeros = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

            //int[] ints = Array.ConvertAll(lines, int.Parse);
            foreach (string item in lines)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == '1')
                    {
                        countedBitsOne[i] = countedBitsOne[i] + 1;
                    }
                    else if (item[i] == '0')
                    {
                        countedBitsZeros[i] = countedBitsZeros[i] + 1;
                    }
                }
            }
            for (int i = 0; i < countedBitsOne.Length; i++)
            {
                if (countedBitsOne[i] > countedBitsZeros[i])
                {
                    finalAnswer += 1;
                }
                else
                {
                    finalAnswer += 0;
                }
            }

            string inverted = "";
            foreach (char item in finalAnswer)
            {
                if (item == '1')
                {
                    inverted += '0';
                }
                else
                {
                    inverted += '1';
                }
            }
            Console.WriteLine(finalAnswer);
            Console.WriteLine();
            List<string> oxygenList = new List<string>();
            List<string> oxygenListTwo = new List<string>();
            List<string> coTwo = new List<string>();
            List<string> coTwoOne = new List<string>();
            List<string> input = new List<string>(lines);
            int index = 0;
            foreach (string? item in input)
            {
                if (item[index] == finalAnswer[index])

                {
                    oxygenList.Add(item);
                }

                if (item[index] == inverted[index])

                {

                    coTwo.Add(item);

                }

            }

            char oneOrZero = '1';
            int countOne;
            int countZeros;
            while (true)
            {
                index++;

                countOne = oxygenList.Count(item => item[index] == '1');
                countZeros = oxygenList.Count(item => item[index] == '0');

                if (countOne >= countZeros)
                {
                    oneOrZero = '1';
                }
                else if (countZeros > countOne)
                {
                    oneOrZero = '0';
                }

                foreach (string? item in oxygenList)
                {

                    if (item[index] == oneOrZero)
                    {
                        oxygenListTwo.Add(item);
                    }
                }

                oxygenList = oxygenListTwo.ToList();
                oxygenListTwo.Clear();

                if (index == 11)
                {

                    break;
                }
            }
            index = 0;
            while (true)
            {
                index++;

                countOne = coTwo.Count(item => item[index] == '1');
                countZeros = coTwo.Count(item => item[index] == '0');

                if (countOne < countZeros)
                {
                    oneOrZero = '1';
                }
                else if (countOne >= countZeros)
                {
                    oneOrZero = '0';
                }

                foreach (string? item in coTwo)
                {

                    if (item[index] == oneOrZero)
                    {
                        coTwoOne.Add(item);
                    }
                }

                coTwo = coTwoOne.ToList();
                if (coTwo.Count == 1)
                {
                    break;
                }
                coTwoOne.Clear();
                if (index == 11)
                {

                    break;
                }
            }

            Console.WriteLine(oxygenList[0]);
            int oxyGen = Convert.ToInt32(oxygenList[0], 2);
            Console.WriteLine(coTwo[0]);
            int cotvo = Convert.ToInt32(coTwo[0], 2);
            Console.WriteLine(oxyGen * cotvo);
           

        }
    }
}

