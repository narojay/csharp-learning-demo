using System;
using System.IO;

namespace 文件边读边写
{
    class Program
    {
        private const int bufferSize = 1024;
        static void Main(string[] args)
        {
            string fileName = @"D:\filetest.txt";
            string fileCopyName = @"D:\filecopy.txt";
            using (FileStream source = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (Stream target = new FileStream(fileCopyName, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[bufferSize];
                    int byteRead;
                    do
                    {
                        byteRead = source.Read(buffer, 0, buffer.Length);

                        target.Write(buffer, 0, byteRead);
                    } while (byteRead > 0);
                }
                
            }
            Console.WriteLine("Hello World!");
        }
    }
}
