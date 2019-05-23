using System;
using System.Threading;
using System.Threading.Tasks;

namespace aynsctest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("主"+Thread.CurrentThread.ManagedThreadId);
           
            Test();
            Console.WriteLine("asdasdads");
            Console.ReadLine();
        }

        static async void Test()
        {
            Task<string> task = Task.Run(() => {
                Console.WriteLine("新"+Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                return "Hello World";
            });
            Console.WriteLine("主" + Thread.CurrentThread.ManagedThreadId);
         
            string str = await task;  //5 秒之后才会执行这里
            Console.WriteLine("test");  
            Console.WriteLine(str);
        }

    }
}
