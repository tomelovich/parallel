using System;
using System.Threading;
using System.Threading.Tasks;

namespace _2_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Task[] ex1 = new Task[2]
            {
                new Task(() => Z1(b)),
                new Task(() => Z2(b))
                
            };

            foreach (var t in ex1)
                t.Start();
            Task.WaitAll(ex1);
            Thread.Sleep(300);
            Console.ReadLine();

        static void Z1(int b)
            {
                double z1 = (Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4)) / Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
                Console.WriteLine( z1);
            }
            static void Z2(int b)
            {
                double z2 = 1 / (Math.Sqrt(b + 2));
                Console.WriteLine(z2);
            }
        }
    }  
}
