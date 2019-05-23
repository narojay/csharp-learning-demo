using System;
using System.Collections.Generic;

namespace 泛型
{
    class Program
    {
        public static List<T> MakeList<T>(T a, T b)
        {
            List<T> list =new List<T>();
            list.Add(a);
            list.Add(b);
            return list;
        }
        static void Main(string[] args)
        {
            var testList = MakeList("test", "testb");
           
            foreach (var testNumber in testList)
            {
                Console.WriteLine(nameof(testNumber));
            }

        }
    }
}
