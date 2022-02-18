using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число для вычесления факториала ");
            int x = Convert.ToInt32(Console.ReadLine());

            Array();
            long b = Metod(x).Result;

            Console.WriteLine($"Факториал = {b}");
            Console.ReadLine();
        }
        static async Task<long> Metod(int x)
        {
            Console.WriteLine("Начало работы Метода");
            long b = await Task.Run(() => Factorial(x));
            Console.WriteLine("Конец работы Метода");
            return b;
        }
        static long Factorial(int x)
        {
            long n = (int)x;
            long a = 1;
            for (int i = 2; i <= n; ++i)
            {
                a *= i;
            }
            return a;
        }
        static void Array()
        {
            int[] array = new int[100];
            int Summ = 0;
            int Max = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Summ += array[i];
                if (Max < array[i]) { Max = array[i]; }
                Console.WriteLine($"Массив 1 элимент {i} = {array[i]}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Сумма массива 1 = {Summ}");
            Console.WriteLine($"Наибольшее число в массиве 1 = {Max}");
        }
    }
}
