
namespace NunitPractice
{
    public interface ICalculator
    {
        int Add(int num1, int num2);
        int Subtract(int num1, int num2);
    }

    public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
