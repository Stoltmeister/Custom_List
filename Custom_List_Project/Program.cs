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
            CustomList<int> test = new CustomList<int>() { 1, 2, 3 };               
            Console.WriteLine(test[1]);
            Console.ReadLine();
        }
    }
}
