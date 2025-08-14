
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'H';
            Console.WriteLine(symbols[0, 0]);

            int[,] nums = 
            {
                {4, 6 ,7},
                {5, 7 ,3},
                {3, 3, 2 }
                
            };

            nums[1, 2] = 56;

        }
    }
}