using System;
using System.Threading;
using System.Threading.Tasks;

namespace testas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Id : {0}\r\n", Thread.CurrentThread.ManagedThreadId);
            Test();
            Console.ReadLine();

        }
        static async Task Test()
        {
            Console.WriteLine("before calling getName, Thread Id : {0}\r\n", Thread.CurrentThread.ManagedThreadId);
            var name = GetName();     
            Console.WriteLine("End calling GetName AAAAAAAAAA.\r\n");
            Console.WriteLine("Get result from GetName: {0}", await name);
            Console.WriteLine("End calling GetName BBBBBBBB.\r\n");
        }
        static async Task<string> GetName()
        {
            Console.WriteLine("before calling task.Run,current thread id is {0}", Thread.CurrentThread.ManagedThreadId);
            return await Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("getName Thread id {0}", Thread.CurrentThread.ManagedThreadId);
                return "jesse";
            });
        }
    }
}
