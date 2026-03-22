using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\cache";
        int count = 0;
        long size = 0;

        foreach (var file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
        {
            FileInfo info = new FileInfo(file);
            size += info.Length;
            info.Delete();
            count++;
        }

        Console.WriteLine($"Deleted: {count}");
        Console.WriteLine($"Size: {size}");
    }
}