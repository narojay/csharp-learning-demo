using System;
using System.Threading;

namespace 线程池
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程ID{0}", Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(CallBackWorkItem);
            Thread.Sleep(3000);
            Console.WriteLine("主线程退出");
        }
        private static void CallBackWorkItem(Object state)
        {
            Console.WriteLine("线程池的线程开始工作");
            if(null == state)
            {
                Console.WriteLine("线程池的iD{0}",Thread.CurrentThread.ManagedThreadId);
            }
            else
            {
                Console.WriteLine("线程池的ID{0}，，，传入的参数{1}", Thread.CurrentThread.ManagedThreadId,state.ToString());
            }
        }
    }
}
