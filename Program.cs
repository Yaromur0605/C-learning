
namespace learning
{
    class Program
    {
        static void Main()
        {

           
            Console.Write("Ведіть число з комою: ");
            //user_input = Convert.ToDouble(Console.ReadLine());
           float user_input = float.Parse(Console.ReadLine());

            float result;
            result = user_input + 10f; 

            result *= 5f; // добавляю 5
            result ++; // ++ значить добавити 1, щоб відняти --
            //result = user_input - 10f;
            //result = user_input * 10f;
            //result = user_input / 10f;
            //result = user_input % 10f;

            //int a =5, b =6;
            //int res = a - b;
            Console.WriteLine("Перемінна" + result);
        }



    }
}