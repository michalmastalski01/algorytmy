using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 7, 5, 6, 4, 2, 1, 8, 9, 3 };
            int[] sorted = new int[tab.Length];
            int[] sortedTab = Sort(tab);
            foreach(int i in sortedTab)
            {
                Console.Write(i);
            }
        }

        static public int[] Sort(int[] tosort, int i = 0)
        {
            int k = 1000;
            if (i >= tosort.Length-1) return tosort;
            for(int j = i; j < tosort.Length; j++)
            {
                if (j == 0) k = tosort[0];

                if (tosort[j] <= k) k = tosort[j];
            }
            int z = Array.IndexOf(tosort, k);
            tosort[z] = tosort[i];
            tosort[i] = k;
            Sort(tosort, i+1);
            return tosort;
        }
    }
}
