using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步列子3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程测试开始..");
            AsyncMethod();
            Console.WriteLine("A"+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("B"+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("主线程测试结束..");
            Console.WriteLine("D" + Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }

        static async void AsyncMethod()
        {
            Console.WriteLine("开始异步代码");
            var result = await MyMethod();
            Console.WriteLine("异步代码执行完毕");
        }

        static async Task<int> MyMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C"+Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("异步执行" + i.ToString() + "..");
                await Task.Delay(1000); //模拟耗时操作
            }
            return 0;
        }
    }
}
