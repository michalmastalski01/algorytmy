using System;
using System.Collections.Generic;
using System.Collections;
/*
namespace lab9
{
    class HashTable : IEnumerable<int>
    {
        List<int>[] arr = new List<int>[101];

        public bool Add(int value)
        {
            int hashCode = HashCode(value);
            if(arr[hashCode] == null)
            {
                arr[hashCode] = new List<int>();
            }
            if(arr[hashCode].Contains(value))
            {
                return false;
            }
            arr[hashCode].Add(value);
            return true;
        }
        public bool Remove(int value)
        {
            int hashCode = HashCode(value);
            if(arr[hashCode] == null || !arr[hashCode].Contains(value))
            {
                return false;
            }
            return arr[HashCode(value)].Remove(value);
        }
        public bool Contains(int value)
        {
            if(arr[HashCode(value)] != null && arr[HashCode(value)].Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int HashCode(int value)
        {
            return value.GetHashCode() % arr.Length;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (List<int> item in arr)
            {
                if (item != null)
                {
                    foreach (int val in item)
                    {
                        yield return val;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2137".GetHashCode());
            Console.WriteLine("2137".GetHashCode());
            Console.WriteLine(2.GetHashCode());

            HashTable table = new HashTable();

            table.Add(15);
            table.Add(21);
            table.Add(3);
            table.Add(3);
            Console.WriteLine(table.Add(3));

            foreach(int? item in table)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
*/