using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>();
            test.Add(11);
            test.Add(22);
            Console.WriteLine(test.Count);
            Console.ReadLine();
        }
    }
}
