using SeqList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> listA = new List<int>() { 3, 6, 9, 11, 14, 16, 19 };
            //List<int> listB = new List<int>() { 2, 3, 4, 6, 8, 9, 10, 12 };
            //MergeClass<int> mergeClass = new MergeClass<int>();
            //var listC = mergeClass.Merge(listA, listB);
            //PrintList(listA);
            //PrintList(listB);
            //PrintList(listC);

            //List<char> charlistA = new List<char>() { 'a', 'c', 'd', 'g', 'p' };
            //List<char> charlistB = new List<char>() { 'b', 'd', 'e', 'f', 'z' };
            //MergeClass<char> charmergeClass = new MergeClass<char>();
            //var charlistC = charmergeClass.Merge(charlistA, charlistB);
            //PrintList(charlistA);
            //PrintList(charlistB);
            //PrintList(charlistC);

            //List<string> stringlistA = new List<string>() { "abc", "bcd", "efg", "opa", "zhouwu", "zz" };
            //List<string> stringlistB = new List<string>() { "aac", "bbd", "bce", "hig" };
            //stringlistB = null;

            //Seq<string> seq = new ConcreteSeq<string>(stringlistA, stringlistB);

            //if (stringlistA ==null || stringlistB ==null)
            //{
            //    seq.MergeWithOneNull();
            //}
            //else
            //{
            //    seq.MergeUntillOneNull();
            //    seq.MergeWithOneNull();
            //}

            ////MergeClass<string> stringMergeClass = new MergeClass<string>();
            //SeqListDesign<string> seqListDesign = new SeqList<string>(stringlistA, stringlistB);
            //Director<string> director = new Director<string>(seqListDesign);
            //var stringlistC = director.GetList();
            ////var stringlistC = stringMergeClass.Merge(stringlistA, stringlistB);
            //PrintList(stringlistA);
            //PrintList(stringlistB);
            //PrintList(seq.listC);

            //string s = "adssdfwesdfwef";
            //char[] charArray = new char[s.Length];
            ////int index = 0;

            ArrayTest at = new ArrayTest();
            at.init();
            at.Shuffle();
            at.Show();

            //int index = 0;
            //while((s!=null&&s!=""))
            //{
            //    charArray[index++] = s.Last();
            //    s = s.Substring(0,s.Length -1);
            //}

            //foreach (char c in charArray)
            //{
            //    Console.Write(c);
            //}
            //♥
            //IMergeFactory<string> iMergeFactory = new NonNullFactory<string>(stringlistA, stringlistB);
            //var listC = iMergeFactory.SeqComposite.Merge();
            //PrintList(listC);

            //int[] arrayA = { 3, 6, 9, 11, 14, 16, 19 };
            //int[] arrayB = { 2, 3, 4, 6, 8, 9, 10, 12 };
            //ArrayMerge arrayMerge = new ArrayMerge();
            //var arrayC = arrayMerge.Merge(arrayA, arrayB);
            //PrintArray(arrayA);
            //PrintArray(arrayB);
            //PrintArray(arrayC);

            //Console.WriteLine(Math.Cacul(30));
            //for(int i= 1; i<=30; i++)
            //{
            //    Console.WriteLine("n = {0}, result = {1}", i, Math.Cacul(i));
            //}

            //List<int> list = new List<int>(0);
            //foreach(int i in list)
            //{
            //    Console.Write(i);
            //}

            //Console.WriteLine(list == null);

            Console.ReadKey();
        }
        static void PrintList(List<string> listp)
        {
            if(listp != null)
            {
                foreach (string i in listp)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
