using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    class ArrayTest
    {
        public string[] cards { get; set; }
        public readonly string[] stlye = new string[4] { "♦", "♥", "♠", "♣" };
        public readonly string[] num = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public ArrayTest()
        {
            this.cards = new string[54];
        }

        public void init()
        {
            for(int i = 0; i<=51; i++)
            {
                cards[i] = string.Format("{0}{1}", stlye[i / 13], num[i % 13]);
            }
            cards[52] = "小王";
            cards[53] = "大王";

        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int k = 0; k< 100; k++)
            {
                int i = r.Next(0, 1000) % 54;
                int j = r.Next(0, 1000) % 54;
                string tmp = cards[i];
                cards[i] = cards[j];
                cards[j] = tmp;
            }
        }

        public void Show()
        {
            for(int i = 0; i<54; i++)
            {
                Console.Write(cards[i]);
                if (i == 13 || i == 26 || i == 39 || i == 52)
                {
                    Console.WriteLine();
                }
            }
        }


        
    }
}
