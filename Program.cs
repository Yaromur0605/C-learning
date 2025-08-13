
using System.Transactions;

namespace learning
{
    class Program
    {
        public static string user_input;
        static void Main()
        {
            Console.WriteLine("Привіт, я твій помічник! Як тебе звати?");
            user_input = Console.ReadLine().ToLower();
            switch_function();

        }

        static void switch_function()
        {
            switch (user_input)
            {
                case "hello":
                    Console.WriteLine("Ти 'hello?'");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Main();
                    break;
                default:
                    Console.WriteLine("{0} Привіт", user_input);
                    break;




            }
        }
    }
}