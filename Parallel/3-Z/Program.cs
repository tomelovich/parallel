using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            string x = Console.ReadLine();
            var outer = Task.Factory.StartNew(() =>      // внешняя задача
            {
                var inner = Task.Factory.StartNew(() =>  // вложенная задача
                {
                    SumCh(x);

                }, TaskCreationOptions.AttachedToParent);
                Console.WriteLine(SumCh(x));
            });
            outer.Wait(); // ожидаем выполнения внешней задачи
            static int SumCh(string N)
            {
                string one, two, three;
                one = (N[0].ToString());
                two = (N[1].ToString());
                three = (N[2].ToString());
                int X = Convert.ToInt32(two + three + one);
                return X;
            }
        }
    }
}
