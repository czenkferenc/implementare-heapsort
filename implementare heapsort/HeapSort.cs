using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementare_heapsort
{
    class HeapSort
    {
        public HeapSort()
        {
        }

        public static void sort<T>(T[] pq) where T : IComparable<T>
        {
            int N = pq.Length;
            for (int k = N / 2; k >= 1; k--)
                sink(pq, k, N);
            while (N > 1)
            {
                exch(pq, 1, N--);
                sink(pq, 1, N);
            }
        }

        private static void sink<T>(T[] pq, int k, int N) where T : IComparable<T>
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(pq, j, j + 1))
                    j++;
                if (!less(pq, k, j))
                    break;
                exch(pq, k, j);
                k = j;
            }
        }
        private static bool less<T>(T[] pq, int i, int j) where T : IComparable<T>
        {
            return pq[i - 1].CompareTo(pq[j - 1]) < 0;
        }

        private static void exch<T>(T[] pq, int i, int j) where T : IComparable<T>
        {
            T swap = pq[i - 1];
            pq[i - 1] = pq[j - 1];
            pq[j - 1] = swap;
        }


        private static bool less<T>(T v, T w) where T : IComparable<T>
        {
            return (v.CompareTo(w) < 0);
        }

        private static bool isSorted<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 1; i < a.Length; i++)
                if (less(a[i], a[i - 1]))
                    return false;
            return true;
        }

        public static void show<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
