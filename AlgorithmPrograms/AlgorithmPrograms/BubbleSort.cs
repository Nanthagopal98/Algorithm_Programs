using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BubbleSort
    {
        string[] values = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Algorithm_Programs\AlgorithmPrograms\Input\Bubble Sort.txt");

        public void BubbleSortofInteger()
        {
            int[] intArray = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                intArray[i] = Convert.ToInt32(values[i]);
            }
            Console.WriteLine("Before sort : ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 1; j < values.Length; j++)
                {
                    
                    if (intArray[j] > intArray[i])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("After sort : ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
    
}
