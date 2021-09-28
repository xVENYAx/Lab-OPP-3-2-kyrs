using System;
using System.IO;

namespace Введення_даних_з_файлу_і_форматований_вивід_даних_різного_типу_в_файл
{
    class Program
    {
        static void Main()
        {
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("out.txt");
            StreamReader f1 = new StreamReader("in.txt");
            f.WriteLine("         Таблиця значень\n");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = Math.Sqrt(x * x / (2 + Math.Exp(4 * Math.Log(x))));
            f.WriteLine(" аргумент x = {0:F3}, функція y = {1:e3} \n", x, y);
            goto metka;
        metka1: f.WriteLine("        Склав Петров Іван {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
