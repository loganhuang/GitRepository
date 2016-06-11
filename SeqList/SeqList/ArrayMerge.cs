using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    class ArrayMerge <T> where T : IComparable
    {
        public T[] Merge(T[] arrayA, T[] arrayB)
        {
            if (arrayA.Length == 0)
            {
                return arrayB;
            }
            else if(arrayB.Length == 0)
            {
                return arrayA;
            }

            T[] arrayC = new T[arrayA.Length + arrayB.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while(i<arrayA.Length && j<arrayB.Length)
            {
                if(arrayA[i].CompareTo(arrayB[j]) <= 0)
                {
                    arrayC[k] = arrayA[i++];
                }
                else
                {
                    arrayC[k++] = arrayB[j++];
                }
            }
            if (i==arrayA.Length)
            {
                for(int tmp = k; tmp < arrayA.Length + arrayB.Length; tmp++)
                {
                    arrayC[k] = arrayB[j++];
                }
            }
            else if(j == arrayB.Length)
            {
                for (int tmp = k; tmp < arrayA.Length + arrayB.Length; tmp++)
                {
                    arrayC[tmp] = arrayA[i++];
                }
            }

            return arrayC;
        }
    }
}
