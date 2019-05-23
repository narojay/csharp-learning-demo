using System;
using System.IO;
using System.Text;

namespace 文件读写
{
    class Program
    {
        private const int bufferlength = 1024;
        static void Main(string[] args)
        {
            string filename = @"D:\filetest.txt";
            string filecontent = GetTestString();
            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                //file create 
                using (FileStream fs = new FileStream(filename, FileMode.Create)) 
                {
                    var bytes = Encoding.UTF8.GetBytes(filecontent);
                    fs.Write(bytes, 0, bytes.Length);
                }
                // file read
                using (FileStream fs = new FileStream(filename,FileMode.Open))
                {
                    var bytes = new byte[bufferlength];
                    var encoding = new UTF8Encoding(true);
                    while (fs.Read(bytes, 0, bytes.Length) > 0)
                    {
                        Console.WriteLine(encoding.GetString(bytes));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string GetTestString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append("测试文件数据");
                stringBuilder.Append("我是narojay"+(i+1) +"\n");

            }
            return stringBuilder.ToString();
        }
    }
}
