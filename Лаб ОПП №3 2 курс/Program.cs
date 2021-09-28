using System;

namespace Лаб_ОПП__3_2_курс
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

            Console.WriteLine("Завдання 1:");
            Console.WriteLine("Скласти програму для введення в діалозі значень змінних А, I, C, L, Name і форматного виведення на екран монітора введених змінних.");
            Console.WriteLine();
            Console.WriteLine("А = 0,095, I = -1, C = 1996, L = false, Name = Фамілія");
            Console.WriteLine();

            double A; // = 0,095;
            int I; // = -1;
            int C; // = 1996;
            bool L; // = false;
            string Name; // = Фамілія;
            
            Console.WriteLine("Input A: "); // Задаємо А
            A = Convert.ToDouble(Console.ReadLine()); // Переводимо з string в double

            Console.WriteLine("Input I: "); // Задаємо I
            I = Convert.ToInt32(Console.ReadLine()); // Переводимо з з string в Int

            Console.WriteLine("Input C: "); // Задаємо C
            C = Convert.ToInt32(Console.ReadLine()); // Переводимо з з string в Int

            Console.WriteLine("Input l: "); // Задаємо l
            L = Convert.ToBoolean(Console.ReadLine()); // Переводимо з з string в bool

            Console.WriteLine("Input фамілію: ");
            Name = Console.ReadLine();
            System.Console.WriteLine(" ");

            System.Console.WriteLine("Результати форматування \nA = {0, 4}, I = {1, 2}, C = {2, 4}", A, C, I); // Показуємо наші значення в консолі
            System.Console.WriteLine("L = {0, 4}, Name = {1, 12}", L, Name);
            
            System.Console.WriteLine(" ");
        }
    }
}
