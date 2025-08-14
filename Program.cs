
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            byte[] nums = new byte[5];
            nums[0] = 250;
            nums[1] = 50;
            nums[2] = 20;
            nums[3] = 100;
            nums[4] = 25;

            //Console.WriteLine("el:" + nums[1]);

            string[] words = ["Bob" ,"John", "Alex"];

            words[1] = "josh";
            Console.WriteLine(words);

            for (byte i = 0; i < words.Length; i++)
                Console.WriteLine(words[i]);
        }
 
    }
}