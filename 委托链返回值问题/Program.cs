using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托链返回值问题
{
    class Program//只会输出委托链的最后一个委托的返回值
    {
        public delegate string ReturnDelegate(int i);

        public static string test1(int i)
        {
            return "one返回值的问题" + i;
        }
        public static string test2(int i)
        {
            return "two返回值的问题" + i;
        }
        static void Main(string[] args)
        {
            ReturnDelegate returnDelegate = test1;
             returnDelegate += test2;
           
            //----------------------------------------------------------
            foreach (var del in returnDelegate.GetInvocationList())//这是可以全部输出返回值的操作
            {
                Console.WriteLine(del.DynamicInvoke());

            }
            Console.ReadKey();
        }
    }
}
