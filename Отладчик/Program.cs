using System;
using System.Diagnostics;
using System.Linq;

namespace Отладчик
{
    public class g
    {
        public void j(int n)
        {
            double d;
            
            for (int i = 0; i < n; i++)
            {
                
                d =Math.Pow(i, 2);
                Console.WriteLine(d);
            }
            Debug.WriteLine("Подсчёт квадратов первых 10 натуральных чисел");
            Trace.WriteLine("Подсчёт квадратов первых 10 натуральных чисел");
        }
        public void l(int n)
        {
            Debug.WriteLine("Ввод массива");
            Trace.WriteLine("Ввод массива");
            int[] a = new int[] { 2,5,3,5,6,3,1,7,3,6};
            int maxValue = a.OrderByDescending(x => x).First();
            Debug.WriteLine("Поиск и вывод макс элемента массива");
            Trace.WriteLine("Поиск и вывод макс элемента массива");
            Debug.Assert(true, "Вы обречены на успех");
            Trace.Assert(true, "Вы обречены на успех");
            Console.WriteLine(a);
            Console.WriteLine(maxValue);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            g f = new g();
            f.j(10);
            f.l(20);
            Debug.Flush();
            Debug.Assert(true, "Вы обречены на успех");
            Trace.Assert(false, "Вы обречены");
            Trace.Assert(true, "Вы обречены на успех");
        }
    }
}
