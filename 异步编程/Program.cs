using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步编程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Id : {0}\r\n",Thread.CurrentThread.ManagedThreadId);
            Test();
            Console.ReadLine();

        }
        static async Task Test()
        {
            Console.WriteLine("before calling getName, Thread Id : {0}\r\n",Thread.CurrentThread.ManagedThreadId);
            var name =  GetName();   //我们这里没有用 await,所以下面的代码可以继续执行
                                    // 但是如果上面是 await GetName()，下面的代码就不会立即执行，输出结果就不一样了。
            Console.WriteLine("End calling GetName.\r\n");
            Console.WriteLine("Get result from GetName: {0}", await name);
        } 
        static async Task<string> GetName()
        {
            Console.WriteLine("before calling task.Run,current thread id is {0}", Thread.CurrentThread.ManagedThreadId);
            return await Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("getName Thread id {0}",Thread.CurrentThread.ManagedThreadId);
                return "jesse";
            });
        }
    }
}
