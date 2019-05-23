using System;
using System.IO;

namespace drivetest
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfo = new DriveInfo("D");
            Console.WriteLine("驱动器的名称：" + driveInfo.Name);
            Console.WriteLine("驱动器类型：" + driveInfo.DriveType);
            Console.WriteLine("驱动器的文件格式：" + driveInfo.DriveFormat);
            Console.WriteLine("驱动器中可用空间大小：" + driveInfo.TotalFreeSpace);
            Console.WriteLine("驱动器总大小：" + driveInfo.TotalSize/1024/1024/1024);

            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("驱动器名称:"+drive.Name);
                    Console.WriteLine("驱动器的文件格式:"+drive.DriveFormat);
                }
            } 
        }
    }
}
