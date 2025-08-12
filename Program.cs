
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            Console.Write("Веди цифру: ");
            Double number = Convert.ToDouble(Console.ReadLine());
            Double a = Math.Pow(number, 2);
            

            if (a < 10)
            {
                Console.WriteLine("{0} small square", a);
            }
            else if (a >= 10 && a <= 100)
            {
                Console.WriteLine("{0} square is medium", a);
            }
            else
            {
                Console.WriteLine("{0} square is big", a);
            }
        }
    }
}