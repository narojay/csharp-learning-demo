using System;
using System.IO;                                                  
namespace 文件操作
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            StreamWriter streamWriter = null;
            string path = "D:\\filetest.txt";
            if (!File.Exists(path))
            {
                fs = File.Create(path);
                Console.WriteLine("新建一个文件{0}", path);

            }
            else
            {
                fs = File.Open(path, FileMode.Open);
                Console.WriteLine("文件村子啊，直接打开 ");
            }
            streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("文件操作测试");
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
            Console.WriteLine("数据流已经关闭");
        }
    }
}
