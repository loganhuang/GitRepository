using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    abstract class Operations
    {
        public double numA { get; set; }
        public double numB { get; set; }

        public abstract double GetResult();
    }

    class Add : Operations
    {

        public override double GetResult()
        {
            return numA + numB;
        }
    }

    class Sub : Operations
    {
        public override double GetResult()
        {
            return numA - numB;
        }
    }

    class Multiply : Operations
    {
        public override double GetResult()
        {
            return numA * numB;
        }
    }

    class Devision : Operations
    {
        public override double GetResult()
        {
            return numA / numB;
        }
    }
}
