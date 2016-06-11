using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OperationFactory
    {
        public Operations operation;
        public OperationFactory(string opera)
        {
            switch (opera)
            {
                case "+":
                    operation = new Add();
                    break;
                case "-":
                    operation = new Sub();
                    break;
                case "*":
                    operation = new Multiply();
                    break;
                case "/":
                    operation = new Devision();
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
