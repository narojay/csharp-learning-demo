using System;
using System.IO;

namespace StreamReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\test.txt";
            using (  var streamReader = new StreamReader(path))
            {
                while (streamReader.Peek() != -1)
                {
                    string str = streamReader.ReadLine();
                    Console.WriteLine(str);
                }
            }

            using (var streamWriter = new StreamWriter(@"D:\test.txt"))
            {
                streamWriter.WriteLine("testab");
                streamWriter.WriteLine("narrrx");
            }
                

        }
    }
}
