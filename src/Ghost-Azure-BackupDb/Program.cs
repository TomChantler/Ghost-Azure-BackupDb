using System;
using System.Data.SQLite;
using System.IO;

namespace Ghost_Azure_BackupDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\home\site\wwwroot\content\data";
            var dbPath = $"{path}{Path.DirectorySeparatorChar}ghost.db";
            var dbBackupPath = $"{path}{Path.DirectorySeparatorChar}backup.db";
            Console.WriteLine($"Backup running in {System.AppContext.BaseDirectory}");
            Console.WriteLine($"About to backup db from {dbPath} to {dbBackupPath}");
            using (var source = new SQLiteConnection($"Data Source={dbPath}; Version=3;"))
            using (var destination = new SQLiteConnection($"Data Source={dbBackupPath}; Version=3;"))
            {
                source.Open();
                destination.Open();
                source.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
            Console.WriteLine("Backed up db successfully");
        }
    }
}