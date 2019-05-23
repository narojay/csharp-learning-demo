using System;
using System.Collections.Generic;
using System.IO;
namespace 文件目录创建
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryInfo = new DirectoryInfo("D:\\code");
            directoryInfo.Create();
            directoryInfo.CreateSubdirectory("code-test1");
            directoryInfo.CreateSubdirectory("code-test2");
            IEnumerable<DirectoryInfo> enumerateDirectories = directoryInfo.EnumerateDirectories();
            foreach (var v in enumerateDirectories)
            {
                Console.WriteLine(v.Name);
            }
            directoryInfo.Delete(true);
        }
    }
}
