
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            short[,] nums = {
                {3,4,2 },
                {2,1,4 },
                {5,9,6 },


            };

            foreach (short el in nums)
            {
                Console.WriteLine("El:" + el );
            }
        }
    }
}