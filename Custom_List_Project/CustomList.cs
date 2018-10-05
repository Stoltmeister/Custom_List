using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Custom_List_Project
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] items = new T[1];
        private int count = 0;
        private int capacity = 4;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        // indexer
        public T this[int i]
        {
            get
            {
                if (i >= count) // FIX OTHER METHODS TO WORK WITH THIS?
                {
                    return default(T);
                    //ArgumentOutOfRangeException e = new ArgumentOutOfRangeException();
                    //throw e;
                }
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        public int Count
        {
            get => count;
        }
        // Check
        public void Add(T value)
        {
            T[] temp = new T[capacity * 2];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = items[i];
            }
            if (Count == capacity)
            {
                capacity = capacity * 2;
            }
            temp[count] = value;
            count++;
            items = temp;
            SetCount();
        }

        public void Remove(T value)
        {
            T[] temp = new T[capacity * 2];
            int itemsRemoved = 0;

            if (count == 0)
            {
                ArgumentOutOfRangeException e = new ArgumentOutOfRangeException();
                throw e;
            }
            for (int i = 0; i <= count; i++)
            {
                if (!items[i].Equals(value))
                {
                    temp[i - itemsRemoved] = items[i];
                }
                else if (items[i].Equals(value))
                {
                    count--;
                    itemsRemoved++;
                }
            }
            items = temp;
            SetCount();
        }

        private void SetCount()
        {
            int i = 0;
            foreach (T value in this)
            {
                i++;
            }
            count = i;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string toString;
            for (int i = 0; i < Count; i++)
            {
                sb.Append(this[i].ToString());
                if (i < Count - 1)
                {
                    sb.Append(", ");
                }
            }
            toString = sb.ToString();
            return toString;
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
                    if (newList[i].Equals(List2[j]))
                    {
                        newList.Remove(newList[i]);
                        i = 0;
                        j = -1;
                    }
                }               
            }

            return newList;
        }

        //public CustomList<T> Zip(CustomList<T> List1, CustomList<T> List2)
        //{
        //    CustomList<T> newList = new CustomList<T>();
        //    int highestCount;

        //    if (List1.Count > List2.Count)
        //    {
        //        highestCount = List1.Count;
        //    }
        //    else
        //    {
        //        highestCount = List2.Count;
        //    }
        //    for (int i = 0; i < highestCount; i++)
        //    {
        //        if (List1[i] != null)
        //        {
        //            newList.Add(List1[i]);
        //        }
        //        if (List2[i] != null)
        //        {
        //            newList.Add(List2[i]);
        //        }
        //    }
        //    return newList;
        //}

    }
}
