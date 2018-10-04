using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        T[] items = new T[1];
        int count;
        
        
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;

            //for (int i = 0; i < this.count; i++)
            //{
            //    T element = this[i];
            //    yield return element;
            //}
        }
        // indexer
        public T this[int i]
        {
            get { return this[i]; }
            set { this[i] = value; }
        }
        public int CompareTo(object list)
        {
            return 0;
        }
        public int Count
        {
            get => count;
        }
        public void Add(T element)
        {

        }

        public void Remove(T element)
        {

        }

        private void SetCount()
        {
            foreach (T e in this)
            {
                count++;
            }
        }

        public override string ToString()
        {
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < List1.Count; i++)
            {
                newList.Add(List1[i]);
            }
            for (int i = 0; i < List2.Count; i++)
            {
                newList.Add(List2[i]);
            }

            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();
            newList = List1;

            for (int i = 0; i < newList.Count; i++)
            {
                for (int j = 0; j < List2.Count; j++)
                {
                    if (newList[i].CompareTo(List2[j]) == 0)
                    {
                        newList.Remove(newList[i]);
                    }
                }
                newList.Remove(newList[i]);
            }

            return newList;
        }

        public static CustomList<T> Zip(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();
            int highestCount;

            if (List1.Count > List2.Count)
            {
                highestCount = List1.Count;
            }
            else
            {
                highestCount = List2.Count;
            }
            for (int i = 0; i < highestCount; i++)
            {
                if (List1[i] != null)
                {
                    newList.Add(List1[i]);
                }
                if (List2[i] != null)
                {
                    newList.Add(List2[i]);
                }
            }
            return newList;
        }


    }
}
