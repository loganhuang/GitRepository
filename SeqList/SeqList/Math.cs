using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqList
{
    class Math
    {
        public static double Cacul(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else if(n==2)
            {
                return 2;
            }
            else
            {
                return Cacul(n - 1) + Cacul(n - 2);
            }
        }

    }
}
