using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    class MergeClass <T> where T : IComparable
    {
        public List<T> Merge(List<T> listA, List<T> listB)
        {
            if(listA == null)
            {
                return listB;
            }
            else if (listB ==null)
            {
                return listA;
            }

            List<T> listC = new List<T>(listA.Count + listB.Count);
            int listAIndex = 0;
            int listBIndex = 0;

            while ((listAIndex < listA.Count) && (listBIndex < listB.Count))
            {
                if ((listA[listAIndex]).CompareTo(listB[listBIndex]) <= 0)
                {
                    listC.Add(listA[listAIndex]);
                    listAIndex++;
                }
                else
                {
                    listC.Add(listB[listBIndex]);
                    listBIndex++;
                }
            }

            if (listAIndex == listA.Count)
            {
                int left = listA.Count + listB.Count - listAIndex - listBIndex;
                for (int i = 0; i< left;i++)
                {
                    listC.Add(listB[listBIndex]);
                    listBIndex++;
                }
            }
            else if(listBIndex == listB.Count)
            {
                int left = listA.Count + listB.Count - listAIndex - listBIndex;
                for (int i = 0; i < left; i++)
                {
                    listC.Add(listA[listAIndex]);
                    listAIndex++;
                }
            }

            return listC;

        }
        public void AddRest()
        {

        }
    }
}
