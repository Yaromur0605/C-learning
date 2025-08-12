
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {


            Console.Write("Enter name: ");
            string role = Console.ReadLine();

            if (role == "admin")
            {
                Console.Write("Enter user name: ");
                string User = Console.ReadLine();
                Console.Write("Enter {0}'s age: ", User);
                short age = Convert.ToInt16(Console.ReadLine());
                if (age <= 0 || age > 99) {
                    Console.Write("Enter {0} age: ", User);
                    age = Convert.ToInt16(Console.ReadLine());
                }
                if(age <= 0 || age > 99)
                {
                    Console.WriteLine("Error");
                }else
                    Console.WriteLine("User's age is " + age);

        
                }
            else
                Console.WriteLine("you are not admin");
        }
    }
}