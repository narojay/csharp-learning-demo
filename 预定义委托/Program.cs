using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 预定义委托
{
    class NameTest
    {
        public string Name { get; set; }
        public NameTest(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Avtion 预定义委托 该方法不具有参数且不返回值。
            Action action = new NameTest("jayH").Display;
            action();
            //
            List<Person> people = new List<Person>()
            {
                new Person(){ID = 10, Name ="JAYh"},
                new Person(){ID = 20, Name ="JAYJ"},
                new Person(){ID = 30, Name ="JAYK"},
            };
            people.ForEach(new Action<Person>(delegate (Person person)
            {
                Console.WriteLine("{0}        {1}",person.Name,person.ID);
            }));
            people.Select(delegate (Person p)
            {
                return new { Name = p.Name };
            });
            people.FindAll(p => p.ID > 20);
            people.ForEach(p => Console.WriteLine("lambda{0}{1}",p.ID,p.Name));// lambda 好爽!!!!!
             var test =  people.Select(p => new Person() { Name = p.Name });
            foreach (var item in test)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
