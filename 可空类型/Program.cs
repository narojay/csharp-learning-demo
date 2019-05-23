using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null; //可空类型
            x = 1;
            if(x != null)
            {
                int y = x.Value;
                Console.WriteLine(y);
            }
            int z = x ?? 10; // null联合操作符 如果x为null 贼返回10 否则返回X
            Console.WriteLine(z);
            Console.Read();
        }
    }
    //输出结果:1
    //        1
}
