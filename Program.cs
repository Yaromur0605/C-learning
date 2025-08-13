
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {


            short user_input = Convert.ToInt16(Console.ReadLine());

            switch (user_input)
            {
                case 5:
                    Console.WriteLine("num is 5");
                    break;
                case 15:
                    Console.WriteLine("num is 15");
                    break;
                case 20:
                    Console.WriteLine("num is 20");
                    break;
                case 250:
                    Console.WriteLine("number is 250");
                    break;
                default:                              //Default можна сказати аналог else
                    Console.WriteLine("number is unrecognized");
                    break;
                    

            }
        }
    }
}