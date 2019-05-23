using System;
using System.Threading;

namespace 多线程基础
{
    class Program
    {
        static void Work()
        {
            Console.WriteLine("线程开始工作");
            Thread.Sleep(1000);
            Console.WriteLine("线程结束");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Work);
                thread.Start();
            }

        }
    }
}
