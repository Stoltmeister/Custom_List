using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Project 
{
    public class CustomList<T> : IEnumerable<T>
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
        // indexer
        public T this[int i]
        {
            get { return this[i]; }
            set { this[i] = value; }
        }
        public System.Collections.IEnumerator GetEnumerator(CustomList<T> list)
        {
            for (int i = 0; i < list.count; i++)
            {
                T element = list[i];
                yield return element;
            }
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
