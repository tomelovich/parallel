using System;
using System.Threading;
using System.Threading.Tasks;

namespace _4_Z
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Parallel.For(5, 15, Arccos);

            // вычисляем квадрат числа
            void Arccos(int n)
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Console.WriteLine($"Арккосинус числа {n} равен {Math.Acos(n)}");
                Thread.Sleep(2000);
            }
        }
    }
}
