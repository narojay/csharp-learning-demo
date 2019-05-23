using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp基础拾遗
{
    class Program
    {
        public delegate void TestDelegate(int i);

        public static void PrintMessage(int i)
        {
            Console.WriteLine("这是第{0}个方法！", i);

        }
        public static void PrintMessage1(int i)
        {
            Console.WriteLine("2这是第{0}个方法！", i);

        }
        static void Main(string[] args)
        {
            //写法1基础写法
            TestDelegate testDelegate = new TestDelegate(PrintMessage);
            testDelegate += new TestDelegate(PrintMessage1);
            //写法2  缩写 编译器帮我们省去了很多的代码
            testDelegate += PrintMessage; 
            testDelegate += PrintMessage1;
            Delegate[] delegates = testDelegate.GetInvocationList();  



            Console.ReadKey();

        }
    }
}
