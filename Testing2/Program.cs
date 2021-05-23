using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li1 = new List<string>();
            li1.Add("Eetu");
            li1.Add("Juuso");
            li1.Add("Tino");
            li1.Add("Aaro");
            Console.WriteLine("Before sorting");

            foreach (var item in li1)
            {
                Console.WriteLine(item);
            }

            li1.MySortFunction();

            Console.WriteLine("After sorting");

            foreach (var item in li1)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static class MyListFunction
    {
        public static void MySortFunction(this List<string> li)
        {
            string temp;
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (string.Compare(li[i], li[j])<0)
                    {
                        //swap
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
                Console.WriteLine(".......................");
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(".......................");
            }
        }
    }
}