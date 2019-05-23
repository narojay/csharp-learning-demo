using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猫叫事件
{
    public  class Cat
    {
        private string name;
        public event EventHandler<CatCryArgs> catEvent;
        public Cat(string name)
        {
            this.name = name;
        }
        public void CatCry()
        {
            CatCryArgs catCryArgs = new CatCryArgs(name);
            Console.WriteLine(catCryArgs.ToString());
            catEvent(this, catCryArgs);
        }


    }
    public class CatCryArgs : EventArgs
    {
        private string catName;
        public CatCryArgs(string catName)
        {
            this.catName = catName;
        }

        public override string ToString()
        {
            string message = string.Format("{0}", catName); 
            return message;
        }
    } 
    public class Mouse
    {
        private string name;
        public Mouse(string name, Cat cat)
        {
            this.name = name;
            cat.catEvent += CatCryEventHandler;
        }
        private void CatCryEventHandler(object sender,EventArgs eventArgs)
        {
            Run();
        }
        private void Run()
        {
            Console.WriteLine(name + "逃走了!");
            Person p = new Person() { Name = "小强", Age = 18 };
        }
    }
    public class Person
    {
        private string name;
        public Person(string name, Cat cat)
        {
            this.name = name;
            cat.catEvent += CatCryEventHandler;
        }
        private void CatCryEventHandler(object sender, EventArgs eventArgs)
        {
            Wakeup();
        }
        private void Wakeup()
        {
            Console.WriteLine(name + "惊醒!");
        }
    }
        public class Program
        {
        static void Main(string[] args)
        {
            Cat cat = new Cat("汤姆");
            Mouse mouse = new Mouse("杰瑞", cat);
            Person person = new Person("我", cat);
            cat.CatCry();
            Console.ReadKey();
        }

        }
    
}
