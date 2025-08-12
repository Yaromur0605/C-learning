
namespace learning
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(Math.Abs(-20)); // Знайти модуль числа
            //Console.WriteLine(Math.Ceiling(4.11f));  // округлити до більшого
            //Console.WriteLine(Math.Floor(4.11f)); // округлити до меншого
            //Console.WriteLine(Math.Round(4.11f)); // округлити
            //Console.WriteLine(Math.Cos(4.11f)); // виводження косинуса
            //Console.WriteLine(Math.Sin(4.11f)); // Виводження синуса
            //Console.WriteLine(Math.Min(5, 0));   // знаходження мінімального числа між іншими
            //Console.WriteLine(Math.Max(88, 0)); // знаходження максимального числа між іншими
            //Console.WriteLine(Math.Pow(5, 2));  // Піднесення до степеня
            //Console.WriteLine(Math.Sqrt(4.11f)); // Знайти квадратний корінь


            Console.WriteLine("Веди радіус круга: ");
            Double radius = Convert.ToDouble(Console.ReadLine());
            Double area = Math.PI * Math.Pow(radius, 2);
            Double Okr = Math.Round(area, 2);
            Console.WriteLine("Площадь круга з радіусом {0} рівна {1} " , radius , Okr);
        }



    }
}