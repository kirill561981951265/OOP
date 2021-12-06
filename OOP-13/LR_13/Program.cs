using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using static LR_13.BKSlog;

namespace LR_13
{
    class Program
    {
        static void Main(string[] args)
        {
            BKSDiskInfo diskInfo = new BKSDiskInfo();
            diskInfo.DiskInfo();
            BKSFileInfo fileInfo = new BKSFileInfo();
            fileInfo.FileData(@"D:\БГТУ\OOP\OOP - 13\LR_13\InfoClasses.cs");
            BKSDirInfo dirInfo = new BKSDirInfo();
            dirInfo.DirInfo(@"D:\БГТУ\OOP\OOP-13\LR_13");
            BKSFileManager fileManager = new BKSFileManager();
            fileManager.FileManager(@"D:\БГТУ\OOP\OOP-13\LR_13");

        }
    }
}
