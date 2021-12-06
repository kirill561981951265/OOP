using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace LR_13
{
    public static class BKSlog
    {
        public const string logFile = @"D:\БГТУ\OOP\OOP-13\LR_13\BKSlogFIle.txt"; //путь к файлу       

        static BKSlog()
        {
            using (StreamWriter w = new StreamWriter(logFile, false)) { }
        }

        public static void WriteLine(string str)
        {
            try //отлов ошибки
            {
                using (StreamWriter w = new StreamWriter(logFile, true)) //создание потока 
                {
                    w.WriteLine(str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public static void SearchByString(string str) //поиск по строке 
        {
            using (StreamReader sr = new StreamReader(logFile, false)) //считывание строк
            {
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine().StartsWith(str))
                        Console.WriteLine(sr.ReadLine());
                }
            }
        }

        public class BKSDiskInfo
        {
            public void DiskInfo()
            {
                BKSlog.WriteLine("Информация о диске:");
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    BKSlog.WriteLine("\tИмя: " + drive.Name); //вывод инфомации о диске 
                    BKSlog.WriteLine("\tТип: " + drive.DriveType);
                    if (drive.IsReady)
                    {
                        BKSlog.WriteLine("\tФайловая система: " + drive.DriveFormat);
                        BKSlog.WriteLine($"\tОбъем свободного места: всего - {drive.TotalFreeSpace / 1000 / 1000 / 1000} GB, доступно - { drive.AvailableFreeSpace / 1024 / 1024 / 1024} GB");
                        BKSlog.WriteLine($"\tОбщий размер: {drive.TotalSize / 1024 / 1024 / 1024} GB");
                        BKSlog.WriteLine("\tМетка тома диска: " + drive.VolumeLabel);
                    }
                    BKSlog.WriteLine("");
                }
            }
        }
        public class BKSFileInfo
        {
            public void FileData(string path)
            {
                BKSlog.WriteLine("Информация о файле:"); //метод вывода инфомации о файле 
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    BKSlog.WriteLine($"\tПолный путь: {fileInf.DirectoryName}");
                    BKSlog.WriteLine($"\tИмя: {fileInf.Name}");
                    BKSlog.WriteLine($"\tОбъем: {fileInf.Length}\n\tРасширение: {fileInf.Extension}\n\tДата создания: {fileInf.CreationTime}");
                }
                else
                {
                    BKSlog.WriteLine("Такого файла не существует");
                }
            }
        }
        public class BKSDirInfo
        {
            public void DirInfo(string dirName)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName); //вывод инфомации о директории 
                BKSlog.WriteLine("\nИнформация о директории:");
                BKSlog.WriteLine($"\tКоличество файлов: {dirInfo.GetFiles().Count()}");
                BKSlog.WriteLine($"\tДата создания: {dirInfo.CreationTime}");
                BKSlog.WriteLine($"\tПодкаталоги: {dirInfo.GetDirectories("*", SearchOption.AllDirectories).Count()}");
                BKSlog.WriteLine($"\tРодительская директория: {dirInfo.Parent}");
            }
        }

    }

    public class BKSFileManager
    {
        public void FileManager(string path) //метод вывода инфомации о директориях и файлах 
        {
            try
            {
                DriveInfo driveInfo = new DriveInfo(path);
                DirectoryInfo dirInfo = Directory.CreateDirectory(@"D:\БГТУ\OOP\OOP-13\LR_13\BKSInspect");
                using (StreamWriter writer = File.CreateText(@"D:\БГТУ\OOP\OOP-13\LR_13\BKSInspect\BKSDirInfo.txt"))
                {
                    writer.WriteLine("Информация");
                }
                File.Copy(dirInfo.FullName + "\\BKSDirInfo.txt", dirInfo.FullName + "\\copied.txt");
                //File.Delete(dirInfo.FullName + "\\BKSDirInfo.txt");
                DirectoryInfo dirInfo1 = Directory.CreateDirectory(driveInfo.Name + "ALLFiles");
                DirectoryInfo currentDirectory = new DirectoryInfo("./");
                foreach (var item in currentDirectory.GetFiles())
                    item.CopyTo(dirInfo1.FullName + "\\" + item.Name, true);
                dirInfo1.MoveTo(dirInfo.FullName + "\\" + dirInfo1.Name);
                DirectoryInfo dirInfo2 = new DirectoryInfo(dirInfo.FullName + "\\" + dirInfo1.Name);
                ZipFile.CreateFromDirectory(dirInfo2.FullName, dirInfo.FullName + "\\arhive.zip");
                DirectoryInfo exInfo = Directory.CreateDirectory(dirInfo.FullName + "\\Ezvlechen");
                using (ZipArchive arch = ZipFile.OpenRead(dirInfo.FullName + "\\arhive.zip"))
                {
                    foreach (ZipArchiveEntry entry in arch.Entries)
                    {
                        entry.ExtractToFile(exInfo.FullName + "\\Ezvlechen_" + entry.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
