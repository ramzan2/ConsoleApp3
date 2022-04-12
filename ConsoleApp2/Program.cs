using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать целочисленную переменную и присвоить ей значение 1
            int a = 1;

            //Создать вещественную переменную и присвоить ей любое значение
            double b = 2;
            //Создать не явно типизированную переменную и присвоить ей любое значение
            var c = 32;
            //Вывести на консоль все переменные в строчку 1 методом
            Console.WriteLine($"{a} {b} {c}");
            //5. Возвести в квадрат целочисленную переменную и вывести результат на консоль
            a = 1 * 1;
            Console.WriteLine(a);
            //
            Console.WriteLine(12 % 4);

            //Принять с консоли 3 числа и перемножить их, результат вывести на консоль
            Console.WriteLine("Введите переменные a, b, c");
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());

            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f * g * e);
            Console.ReadKey();

            // Принять с консоли 2 числа и найти большее из них
            Console.WriteLine("Введите два числа");
            int w = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (w > d)
            {
                Console.WriteLine("{0} набиольшее число ", w);
            }
            else
            {
                Console.WriteLine("{0} наибольшее число ", d);
            }
            Console.ReadLine();

            //Принять с консоли 2 числа если оба четные то сложить их иначе перемножить, ответ вывести на консоль  
            Console.WriteLine("Введите два числа");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());






        }
    }
}

