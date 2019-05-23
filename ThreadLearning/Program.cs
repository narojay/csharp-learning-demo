using System;
using System.Threading;

namespace ThreadLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread backThread = new Thread(Working);
            backThread.IsBackground =true;
            backThread.Start();
            backThread.Join();
            Console.WriteLine("主线程退出了");
        }
        public static void Working()
        {
            Thread.Sleep(1000);
            Console.WriteLine("从后台线程退出");
        }
    }
}
