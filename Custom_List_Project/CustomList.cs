using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project
{
    public class CustomList<T>
    {
        T[] items = new T[1];
        int count;

        public int Count
        {
            get => count;
        }
        public void Add()
        {

        }

        public void Remove()
        {

        }

        public void SetCount()
        {

        }

        public override string ToString()
        {
            return "";
        }

        public static CustomList<T> operator + (CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();

            // TO DO
            return newList;
        }

        public static CustomList<T> operator - (CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();

            // TO DO
            return newList;
        }

        public static CustomList<T> Zip(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();

            // TO DO
            return newList;
        }


    }
}
