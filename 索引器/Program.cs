using System;

namespace 索引器
{
    //简化对类中数组成员的访问
    class Person
    {
        private int[] intarray = new int[10];

        public int this[int index]
        {
            get
            {
                return intarray[index];
            }

            set
            {
                intarray[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person[0] = 1;
            person[1] = 2;
            person[2] = 3;
            Console.WriteLine(person[0]);
            Console.WriteLine(person[1]);
            Console.WriteLine(person[2]);
        }
    }
}
