using System;
using System.Collections;
using System.Collections.Generic;

namespace 迭代器
{
    public class MyIEnumerable : IEnumerable
    {
        public void test()
        {

        }
        private string[] strlist;

        public MyIEnumerable(string[] strlist)
        {
            this.strlist = strlist;
        }
        public IEnumerator GetEnumerator()// 获取IEnumerator 接口实例
        {
            // return new MyIEnumerator(strlist);
            for (int i = 0; i < strlist.Length; i++)
            {
                yield return strlist[i];
            }
        }
    }

    public class MyIEnumerator : IEnumerator
    {
        private string[] strlist;
        private int position;
        public MyIEnumerator(string[] strlist)
        {
            this.strlist = strlist;
            position = -1;
        }

        public object Current => strlist[position];

        public bool MoveNext()//判断是否可以进行循环 并且索引加1
        {
            position++;
            if (position < strlist.Length)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] strlist = new string[] { "如果有一天我要去流浪", "不是因为我厌倦了家乡", "不是难忍这里冬天太长", "而是我得知了你的方向" };
            MyIEnumerable my = new MyIEnumerable(strlist);
            var test = my.GetEnumerator();
            while (test.MoveNext()) 
            {
                Console.WriteLine(test.Current);//取值
            }

            Console.WriteLine("==========================================分割线=====================================");
            foreach (var item in my)
            {
                Console.WriteLine(item);
            }
        }
    }
}
