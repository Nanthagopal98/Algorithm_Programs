using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BinarySearchWord
    {
        public void BinaryOutput(string input)
        {
            string[] text = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Algorithm_Programs\AlgorithmPrograms\Input\Binaryinput.txt");
            for (int i = 0; i < text.Length; i++)
            {
                int val = string.Compare(input, text[i]);
                
               // int val = input.CompareTo(text[i]);

                if (val == 0)
                {
                    Console.WriteLine(val);
                    Console.WriteLine(text[i]);
                }
                if (val < 1)
                {
                    Console.WriteLine(val);
                    
                }
                if (val > 1)
                {
                    Console.WriteLine(val);

                }




            }

        }
    }
}
