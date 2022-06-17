using System;
using System.Threading.Tasks;

namespace _1_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string N = Console.ReadLine();
            Task task1 = new Task(() => SumCh(N));
            task1.Start();
            task1.Wait();
            Task task2 = Task.Factory.StartNew(() => SumCh(N));
            Task task3 = Task.Run(() => SumCh(N));
        }
       
        public static void SumCh(string N)
        {
            string one, two, three;
            one = (N[0].ToString());
            two = (N[1].ToString());
            three = (N[2].ToString());
            int X = Int32.Parse(one) * Int32.Parse(two) * Int32.Parse(three);
            Console.WriteLine("Результат умножения цифр = {0}", X);
        }
    }
}
