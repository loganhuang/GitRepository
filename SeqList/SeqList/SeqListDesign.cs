using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    abstract class SeqListDesign<T> where T : IComparable
    {
        public int ListACount { get; private set; }
        public int ListBCount { get; private set; }

        public List<T> listA { get; private set; }
        public List<T> listB { get; private set; }
        public List<T> listC { get; set; }
        public SeqListDesign(List<T> listA, List<T> listB)
        {
            this.listA = listA;
            this.listB = listB;
            this.ListACount = listA.Count;
            this.ListBCount = listB.Count;
            this.listC = new List<T>(ListACount + ListBCount);
        }

        public abstract void MergeNonNull(List<T> listA, List<T> listB);
        public abstract void MergeOneNull(List<T> list);
    }

    class SeqList<T> : SeqListDesign<T> where T: IComparable
    {
        public SeqList(List<T> listA, List<T> listB) : base(listA, listB) { }
        public override void MergeOneNull(List<T> list)
        {
            if(list != null)
            {
                foreach(T t in list)
                {
                    listC.Add(t);
                }
            }            
        }
        public override void MergeNonNull(List<T> listA, List<T> listB)
        {
            int listAIndex = 0;
            int listBIndex = 0;
            while(listAIndex <ListACount && listBIndex < ListBCount)
            {
                if (listA[listAIndex].CompareTo(listB[listBIndex]) <= 0)
                {
                    listC.Add(listA[listAIndex++]);
                }
                else
                {
                    listC.Add(listB[listBIndex++]);
                }
            }
            if(listBIndex == ListBCount)
            {
                listA = listA.GetRange(listAIndex, ListACount - listAIndex);
                MergeOneNull(listA);
            }
            else
            {
                listB = listB.GetRange(listBIndex, ListACount - listBIndex);
                MergeOneNull(listB);
            }
        }
    }

    class Director<T> where T: IComparable
    {
        SeqListDesign<T> seqListDesign;

        public Director(SeqListDesign<T> seqListDesign)
        {
            this.seqListDesign = seqListDesign;
        }

        public List<T> GetList()
        {
            if (seqListDesign != null)
            {
                if(seqListDesign.listA == null)
                {
                    seqListDesign.MergeOneNull(seqListDesign.listB);
                }
                else if (seqListDesign.listB == null)
                {
                    seqListDesign.MergeOneNull(seqListDesign.listA);
                }
                else
                {
                    seqListDesign.MergeNonNull(seqListDesign.listA, seqListDesign.listB);
                }
                return seqListDesign.listC;
            }
            else
            {
                return null;
            }

        }
    }



 
}
