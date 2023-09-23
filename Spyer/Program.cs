using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyer
{
    internal class Program
    {
        private static void MonitorDirectory()
        {
            var watcher = new FileSystemWatcher(@"C:\");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Created += FileSystemWatcher_Created;
            watcher.Deleted += FileSystemWatcher_Deleted;
            watcher.Renamed += FileSystemWatcher_Renamed;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" [+] File created: {e.Name}");

        }

        private static void FileSystemWatcher_Renamed(object sender, FileSystemEventArgs e)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" [#] File renamed: {e.Name}");

        }

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" [-] File deleted: {e.Name}");

        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 20);
            Console.Title = "Spyer || Created from SUPER";
            Console.WriteLine();
            Console.WriteLine(@" [i] Scan started on C:\ Press any key to stop the scan. (Starting in 2 seconds)");
            Console.WriteLine();
            Task.Delay(1500);
            MonitorDirectory();
            Console.ReadKey();
        }
    }
}
