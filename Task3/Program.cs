using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Test";
        FileInfo largest = null;

        foreach (var file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
        {
            FileInfo info = new FileInfo(file);

            if (largest == null || info.Length > largest.Length)
                largest = info;
        }

        Console.WriteLine($"Name: {largest.Name}");
        Console.WriteLine($"Size: {largest.Length}");
        Console.WriteLine($"Path: {largest.FullName}");
    }
}