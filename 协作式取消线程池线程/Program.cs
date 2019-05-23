using System;
using System.IO;
using System.Threading;

namespace 协作式取消线程池线程
{
    class Program
    {
        private static void Callback(object state)
        {
           
            CancellationToken token = (CancellationToken)state;
            Console.WriteLine("开始计数");
            Count(token, 1000); 

         }
        private static void Count(CancellationToken token, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("计数取消");
                    return;
                }
                Console.WriteLine("计数为:" + i);
                Thread.Sleep(300);
               
            }
            Console.WriteLine("计数完成");
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("主线程运行");
            CancellationTokenSource cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(Callback, cts.Token);
            Console.WriteLine("按下回车键来取消操作");
            Console.Read();
            cts.Cancel();
            Console.ReadKey();
        }

     
    }
}
