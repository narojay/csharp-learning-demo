using System;

namespace 委托
{
    class Program
    {
        // 委托是用来传递方法的类型 比如 int 是传递数字的类型。
        public delegate void AddDelegate();

        public delegate void MailDelegate();
       
        public static void SendSuccess()
        {
            Console.WriteLine("mail send success.");
        }

        public static void SendError()
        {
            Console.WriteLine("mail send error.");
        }
        public void SendMails(MailDelegate success, MailDelegate error)
        {
            if (true)
            {
                success();
            }
        }
        public void Add()
        {
            Console.WriteLine(1 + 2);
        }
        static void Main(string[] args)
        {
            new Program().SendMails(SendSuccess, SendError);
        }
    }
}
