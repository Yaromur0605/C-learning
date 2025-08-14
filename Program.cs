
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            short[] numbers = new short[10];
            short summa = 0;

            Random random = new Random();
            for (byte i = 0; i < numbers.Length; i++)
            {
                
                numbers[i] = Convert.ToInt16(random.Next(-15, 15));
                Console.WriteLine("El: " + numbers[i]);
                summa += numbers[i];
            }
            Console.WriteLine("Summa:" + summa);
        }
    }
}