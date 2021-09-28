using System;
using System.IO;

namespace _2_завдання
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // для того, щоб консоль розпізнавав українські літери
            Console.WriteLine("Виконав роботу студент 2 курсу групи МН-205 ФАЕТ.");
            Console.WriteLine("Нагайченко Олександр Олегович");
            Console.WriteLine("Варіант-7");
            Console.WriteLine();

            Console.WriteLine("Завдання 2:");
            Console.WriteLine("Скласти програму для обчислення і друку значень функції з таблиці 2.4. Обчислити 8 значень функції на заданому інтегралі. Вихідні дані задавати в файлі LAB2.TXT. Результате помістити в файл виводу з ім'ям LAB2.RES в заданій формі.");
            Console.WriteLine();
            Console.WriteLine("Контрольні значення:\nX = 1, Y = 1");
            Console.WriteLine("Інтеграл:\nXmin = -1, Xmax = 1");
            Console.WriteLine();
            Console.WriteLine("Варіант форми виводу: 3");
            Console.WriteLine();

            string s;
            double y;
            double x;
            StreamWriter f = new StreamWriter("LAB2.res"); // Файл для виводу даних
            StreamReader f1 = new StreamReader("LAB2.txt"); // Файл для вводу даних
            f.WriteLine("Таблиця значень\n+-------------------------------------+\nАргумент    +   Функція\n+-------------------------------------+");
        metka: s = f1.ReadLine();          
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = 2-((Math.Pow(Math.E, 2*x) + Math.Pow(Math.E, -2 * x))/ (Math.Pow(Math.E, 2)+ Math.Pow(Math.E, -2))); // наша функція

            f.WriteLine("+ x = {0:F3} + y = {1:e3} +\n", x, y);
            goto metka;
        metka1: f.WriteLine("+-------------------------------------+\nСклав Нагайченко Олександр Олегович {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
