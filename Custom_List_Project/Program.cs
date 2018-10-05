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
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;            
            customList.Add(value);
            customList.Add(value1);
            Console.WriteLine(customList[1]);
            customList.Remove(value);
            Console.WriteLine(customList[0]);
            Console.ReadLine();

        }
    }
}
