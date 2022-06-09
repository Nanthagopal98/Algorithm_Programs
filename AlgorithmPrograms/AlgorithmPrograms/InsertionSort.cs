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
            Console.WriteLine("Before sort : ");
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            for (int i = 1; i < text.Length; i++)
            {
                for (int j = i - 1; j >= 0;)
                {
                    int val = string.Compare(text[j], text[i]);
                    if (val > 0)
                    {
                        string temp = text[j];
                        text[j] = text[i];
                        text[i] = temp;
                        i = j;
                    }
                    j--;
                }

            }
            Console.WriteLine("------------------------");
            Console.WriteLine("After sort :");
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }


    }
}
