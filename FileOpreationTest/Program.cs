using System;
using System.IO;

namespace FileOperationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("D:\\code");
            var fileInfo = new FileInfo("D:\\code\\test1.txt");
            if (! fileInfo.Exists)
            {
                fileInfo.Create().Close();//必须close 不然文件一直被创建文件的进程占用了
            }

            fileInfo.Attributes = FileAttributes.Normal;
            Console.WriteLine("文件路径:"+fileInfo.Directory);
            Console.WriteLine("文件名称:"+fileInfo.Name);
            Console.WriteLine("文件是否只读:"+fileInfo.IsReadOnly);
            Console.WriteLine("文件大小:"+fileInfo.Length);
            Console.WriteLine("文件大小:"+File.GetCreationTime("D:\\code\\test1.txt"));
            Directory.CreateDirectory("D:\\code-1");
            var info = new FileInfo("D:\\code-1\\test1.txt");
            if (!info.Exists)
            {
                fileInfo.MoveTo("D:\\code-1\\test1.txt");
            }
        }
    }
}
