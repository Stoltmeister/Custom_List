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
            return GetEnumerator();
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
                if (i >= count) 
                {
                    return default(T);
                    //ArgumentOutOfRangeException e = new ArgumentOutOfRangeException();
                    //throw e;
                    // should be working as currently coded
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

        public CustomList<T> Zip(CustomList<T> List2)
        {
            CustomList<T> newList = new CustomList<T>();
            int highestCount;

            if (Count > List2.Count)
            {
                highestCount = Count;
            }
            else
            {
                highestCount = List2.Count;
            }
            for (int i = 0; i < highestCount; i++)
            {
                if (i < Count)
                {
                    newList.Add(this[i]);
                }
                if (i < List2.Count)
                {
                    newList.Add(List2[i]);
                }
            }
            return newList;
        }

        public CustomList<T> Sort(int start = 0) 
        {
            string[] temp = new string[this.count];
            int[,] originalValues = new int[count,2];
            CustomList<T> sortedList = new CustomList<T>();
            int mid = count / 2;
            int end = count - 1;

            if (count == 1)
            {
                return this;
            }

            if (!IsNum(this))
            {
                for (int i = 0; i < count; i++)
                {
                    temp[i] = this[i].ToString().ToUpper();
                    originalValues[i,0] =  i;
                    originalValues[i, 1] = CharToInt(temp[i][0]);
                }

            }
            


        }

        private static int[] SortNumbers(int[] unsortedArray)
        {
            int[] sortedArray = new int[2];
            if (unsortedArray[0] > unsortedArray[1])
            {
                sortedArray[0] = unsortedArray[1];
                sortedArray[1] = unsortedArray[0];
            }
            return sortedArray;
        }

        private static int CharToInt(char x)
        {
            switch (x)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 7;
                case 'H': return 8;
                case 'I': return 9;
                case 'J': return 10;
                case 'K': return 11;
                case 'L': return 12;
                case 'M': return 13;
                case 'N': return 14;
                case 'O': return 15;
                case 'P': return 16;
                case 'Q': return 17;
                case 'R': return 18;
                case 'S': return 19;
                case 'T': return 20;
                case 'U': return 21;
                case 'V': return 22;
                case 'W': return 23;
                case 'X': return 24;
                case 'Y': return 25;
                case 'Z': return 26;
                default: return 0;
            }
        }

        private static bool IsNum(CustomList<T> list)
        {
            switch (Type.GetTypeCode(list.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
    }
}
