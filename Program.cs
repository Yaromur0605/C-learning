
using System.Transactions;

namespace learning
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("How can i call you");
            Thread.Sleep(200);
            Console.Write("Name: ");
            string a = (Console.ReadLine().ToLower());
            string[] spt = ["gay", "fuck", "bitch","asshole","idiot",",dumb"];

            if (spt.Any(swearing => a.Contains(swearing)))
            {
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("Ban word has been found");
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
             else if (string.IsNullOrWhiteSpace(a)) {
                Console.Clear();

                for (int i = 0; i <3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                    
                }
                Console.Clear() ;
                Main();

            }

            else if (a == "admin")
            {
                Console.Clear();
                Thread.Sleep(300);
                Console.WriteLine("hello boss :)");
                Thread.Sleep(1000);
                
                UI();
            }
            else
            {
                Console.WriteLine("{0}, hello", a);
                UI();


            }
            static void UI()
            {
                Console.Clear();
                bool IsUserLoggedOut = false;
                Console.WriteLine("What do you wanna do?");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("log out, (we don't have anything else log out :D )");


                while (!IsUserLoggedOut)
                {
                   
                   Console.Write("User: ");
                   string b = Console.ReadLine().ToLower();
                    if (b == "log out")
                    {
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");

                        }
                        Thread.Sleep(400);
                        Console.WriteLine();
                        Console.WriteLine("Bye see you next time :)");
                        Thread.Sleep(1000);
                        Console.Clear();

                        IsUserLoggedOut=true;
                        Console.Clear();

                    }
                    else
                    {
                        IsUserLoggedOut = false;
                        Console.Clear();
                    }
                    
                }
                   Main();
            }
            
        }
    }
}