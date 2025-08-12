
namespace learning
{
    class Program
    {
        static void Main()
        {

            int a = 5;
            bool isHasCar = false;

            if (a > 7)
            {
                Console.WriteLine("a > 7");
            }
            else if (a < 5)
            {
                Console.WriteLine("a<5");

            }
            else if ((a == 5 || isHasCar) && a > 2)
            {                                                       /* || Значить та. Скажемо якщо а = 5 ,але IsHasCar буде true 
                                                                    код виконаєтья ,бо одна з умов виконана, але && значить що 2 умови мають  бути виконані */
                                            
                Console.WriteLine("a = 5");
                Console.WriteLine("User has not car!");
            }
            else
            {
                Console.WriteLine("a != 5");
            }

        }
    }
}