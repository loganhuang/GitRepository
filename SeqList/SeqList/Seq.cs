using System;
using System.Collections.Generic;


namespace SeqList
{
    public abstract class Seq <T> where T : IComparable
    {
        public List<T> listA { get; set; }
        public List<T> listB { get; set; }
        public List<T> listC { get; set; }
        public Seq(List<T> listA, List<T> listB)
        {
            this.listA = listA;
            this.listB = listB;
            this.listC = new List<T>(((listA != null) ? listA.Count : 0) + ((listB !=null)?listB.Count:0));
        }

        public void MergeWithOneNull()
        {
            List<T> listTMP = listA ?? listB;
            if (listTMP != null)
            {
                foreach (T t in listTMP)
                {
                    listC.Add(t);
                }
            }
        }
        public abstract void MergeUntillOneNull();
    } 

    public class ConcreteSeq <T> : Seq<T> where T : IComparable
    {
        public ConcreteSeq(List<T> listA, List<T> listB) : base(listA, listB) { }

        public override void MergeUntillOneNull()
        {
            int i = 0;
            int j = 0;
            while ((i<listA.Count)&&(j<listB.Count))
            {
                if(listA[i].CompareTo(listB[j])<=0)
                {
                    listC.Add(listA[i++]);
                }
                else
                {
                    listC.Add(listB[j++]);
                }
            }
            if(i == listA.Count)
            {
                listA = null;
                listB = listB.GetRange(j, listB.Count - j);
            }
            else
            {
                listA = listA.GetRange(i, listA.Count - i);
                listB = null;
            }
        }
    }
}
