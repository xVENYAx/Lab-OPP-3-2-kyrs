using System;

namespace форматований_вивід_даних_різного_типу
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int a = -14;
            float c = -0.00151f;
            double i = 1234.56789;
            bool l = false;
            string name = "Petrov";
            System.Console.WriteLine("name = {0, 6}, l = {1, 4}", name, l);
            System.Console.WriteLine("a = {0, 4}, c = {1,10:f5}, i = {1,20:e8}", a, c, i);
            System.Console.WriteLine("Для виходу натисніть на Enter");
            System.Console.ReadKey();
        }
    }
}
