using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\cache";
        int count = 0;
        long size = 0;

        ClearCache(path, ref count, ref size);

        Console.WriteLine($"Deleted: {count}");
        Console.WriteLine($"Size: {size}");
    }

    static void ClearCache(string path, ref int count, ref long size)
    {
        foreach (var file in Directory.GetFiles(path))
        {
            FileInfo info = new FileInfo(file);
            size += info.Length;
            info.Delete();
            count++;
        }

        foreach (var dir in Directory.GetDirectories(path))
        {
            ClearCache(dir, ref count, ref size);
        }
    }
}