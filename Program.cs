using System;
using System.Numerics;


namespace learning
{
    class Program
    {
        static void Main()
        {
            sbyte number = 127; // ДУЖЕ сильно економить память діапазон від -128 до 127
            //byte number = 255 ; //Зберігає число від 0 до 255 силько еконопить пам'ять
            //short number = 23000; //Зберігає число від -32 768 до -32 767 еконопить пам'ять
            //int number = 2147483647; // не економить память. Діапазон від -2 147 483 648 до 2 147 483 647


            string word = " hello brother "; // Ну... просто слова

            float num = 4.5f; //число і числа після коми

            char symbol = '3'; //Може виводити лише 1 символ

            bool isHappy = false; // Присвоєння True або False

            Console.WriteLine(isHappy + word + number +".");




            //Console.WriteLine("hello world");
        }
    }



}