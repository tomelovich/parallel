using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _5_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 43, 16, 92 },Square);
            void Square(int n, ParallelLoopState pls)
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                int sum = n + n;
                int proizv = n * n;
                if (sum > 535) pls.Break();
                if (proizv > 535) pls.Break();

                Console.WriteLine("Сумма = {0}",sum);
                Console.WriteLine("Произведение = {0}",proizv);
                
                Thread.Sleep(2000);
            }
        }
    }
}
