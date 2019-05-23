using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名类
{
    class Program
    {
        static void Main(string[] args)
        {
            var annoyCla1 = new
            {
                id = 100,
                name = "sds",
                age = 25
            };
           // annoyCla1.id = 101;  属性只读
        Console.WriteLine("ID:{0}-Name:{1}-Age:{2}", annoyCla1.id,annoyCla1.name, annoyCla1.age);
        }
    }
}
