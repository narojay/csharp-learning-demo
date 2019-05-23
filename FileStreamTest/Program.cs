using System;
using System.IO;
using System.Text;

namespace FileStreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\testfilestream.txt";
            using (FileStream fileStream =new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string message = "1567812";
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                fileStream.Write(bytes, 0,bytes.Length);
            }
        }
    }
}
