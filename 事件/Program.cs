using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    /// <summary>
    /// 自定义一个事件参数类型
    /// </summary>
    public class ConsoleEventArgs : EventArgs
    {
        public string Message { get; }

        public ConsoleEventArgs()
            : base()
        {
            this.Message = string.Empty;
        }

        public ConsoleEventArgs(string message)
            : base()
        {
            this.Message = message;
        }
        /// <summary>
    /// 管理控制台，在输出前发送输出事件
    /// </summary>
   
    }
    public class ConsoleManager
    {
        // 定义控制台事件成员对象
        public event EventHandler<ConsoleEventArgs> ConsoleEvent;

        /// <summary>
        /// 控制台输出
        /// </summary>
        public void ConsoleOutput(string message)
        {
            EventHandlerList
            // 发送事件
            ConsoleEventArgs args = new ConsoleEventArgs(message);
            SendConsoleEvent(args);
            // 输出消息
            Console.WriteLine(message);
        }

        /// <summary>
        /// 负责发送事件
        /// </summary>
        /// <param name="args">事件的参数</param>
        protected virtual void SendConsoleEvent(ConsoleEventArgs args)
        {
            // 定义一个临时的引用变量，确保多线程访问时不会发生问题
            EventHandler<ConsoleEventArgs> temp = ConsoleEvent;
            if (temp != null)
            {
                temp(this, args);
            }
        }
    }
    /// <summary>
    /// 日志类型，负责订阅控制台输出事件
    /// </summary>
    public class Log
    {
        // 日志文件
        private const string logFile = @":\TestLog1.txt";

        public Log(ConsoleManager cm)
        {
            // 订阅控制台输出事件
            cm.ConsoleEvent += this.WriteLog;
        }

        /// <summary>
        /// 事件处理方法，注意参数固定模式
        /// </summary>
        /// <param name="sender">事件的发送者</param>
        /// <param name="args">事件的参数</param>
        private void WriteLog(object sender, EventArgs args)
        {
            // 文件不存在的话则创建新文件
            if (!File.Exists(logFile))
            {
                using (FileStream fs = File.Create(logFile)) { }
            }

            FileInfo fi = new FileInfo(logFile);

            using (StreamWriter sw = fi.AppendText())
            {
                ConsoleEventArgs cea = args as ConsoleEventArgs;
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "|" + sender.ToString() + "|" + cea.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 控制台事件管理者
            ConsoleManager cm = new ConsoleManager();
            // 控制台事件订阅者
            Log log = new Log(cm);

            cm.ConsoleOutput("测试控制台输出事件");
            cm.ConsoleOutput("测试控制台输出事件");
            cm.ConsoleOutput("测试控制台输出事件");

            Console.ReadKey();
        }
    }
}
