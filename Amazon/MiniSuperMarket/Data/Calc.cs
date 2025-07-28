using MiniSuperMarket.Interface;

namespace MiniSuperMarket.Data
{
    public class Calc : ICalc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
