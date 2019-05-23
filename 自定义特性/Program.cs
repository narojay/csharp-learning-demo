using System;
using System.Reflection;

namespace 自定义特性
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomizeAttribute : Attribute
    {
        public string CreateTime { get; set; }
        public string CreateName { get; set; }
        public string Message { get; set; }
        public CustomizeAttribute(string createTime, string createName, string message)
        {
            CreateTime = createTime;
            CreateName = createName;
            Message = message;
        }
    }
    [Customize("2019-4-24","jayH","自定义特性的测试")]
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Program);
            CustomizeAttribute customizeAttribute = (CustomizeAttribute)Attribute.GetCustomAttribute(info, typeof(CustomizeAttribute));
            Console.WriteLine("类名：{0}",info.Name);
            Console.WriteLine("创建时间：{0}",customizeAttribute.CreateTime);
            Console.WriteLine("创建人：{0}",customizeAttribute.CreateName);
            Console.WriteLine("信息：{0}",customizeAttribute.Message);


        }
    }
}
