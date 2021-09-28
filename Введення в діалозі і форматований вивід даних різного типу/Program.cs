using System;

namespace Введення_в_діалозі_і_форматований_вивід_даних_різного_типу
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int a; // = -14;
            float c; // = -0.00151f;
            double i; // = 1234.56789;
            bool l; // = false;
            string name; // = "Petrov";
            Console.WriteLine("Input фамілію ");
            name = Console.ReadLine();
            Console.WriteLine("Input a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input c");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input l");
            l = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine(" Результати форматування \n name = {0, 6}, l = {1, 4}", name, l);
            System.Console.WriteLine("a = {0, 4}, c = {1,10:f5}, i = {2,20:e8}", a, c, i);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Для виходу натисніть на Enter");
            System.Console.ReadKey();
        }
    }
}
