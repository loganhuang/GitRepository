using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 6.0;
            Operations operation = (new OperationFactory("+")).operation;
            operation.numA = a;
            operation.numB = b;
            Console.WriteLine(operation.GetResult());
            Console.ReadKey();
        }
    }
}
