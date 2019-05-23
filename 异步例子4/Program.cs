using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步例子4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMain();
        }

        static void TestMain()
        {
            Console.Out.Write("Start\n");
            GetValueAsync();
            Console.Out.Write("End\n");
            Console.ReadKey();
        }

        static async Task GetValueAsync()
        {
            await Task.Run(() =>
            {
               
                for (int i = 0; i < 5; ++i)
                {
                    Thread.Sleep(2000);
                    Console.Out.WriteLine(String.Format("From task : {0}", i));
                }
            });
            Console.Out.WriteLine("Task End");
        }
    }
}
