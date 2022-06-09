using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Ordered_List
    {
        public void OrderedList()
        {
            string inputString = System.IO.File.ReadAllText(@"D:\Bridgelabz\.Net\Algorithm_Programs\AlgorithmPrograms\Input\OrderedList.txt");
            string[] arrayOfString = inputString.Split(',');
            int[] array = arrayOfString.Select(int.Parse).ToArray();
            Lists<int> list = new Lists<int>();
            Console.WriteLine("Data present in the list:");
            foreach (int num in array)
            {
                list.OrderedList(num);
                Console.Write(num + " ");
            }
            list.Display();
            Console.Write("\nEnter the value you want to search : ");
            int searchValue = Convert.ToInt32(Console.ReadLine());
            list.Search(searchValue);
            if (list.flag == 0)
            {
                Console.WriteLine("Inserting " + searchValue + " in the linked list");
                list.OrderedList(searchValue);
            }
            if (list.flag == 1)
            {
                list.DeleteValue(searchValue);
            }
            list.Display();
        }
    }
}
