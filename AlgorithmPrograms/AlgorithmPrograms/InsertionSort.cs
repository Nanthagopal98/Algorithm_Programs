using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class InsertionSort
    {
        string[] text = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Algorithm_Programs\AlgorithmPrograms\Input\Binaryinput.txt");

        public void StringInserTionSort()
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine("Before sort : " + text[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j < text.Length; j++)
                {
                    int val = string.Compare(text[j], text[i]);
                    if (val < 0)
                    {
                        string temp = text[j];
                        text[j] = text[i];
                        text[i] = temp;
                    }
                }
            }
            Console.WriteLine("------------------------");
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine("After sort : " + text[i]);
            }
        }


    }
}
