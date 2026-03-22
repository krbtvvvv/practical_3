using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Test";

        Console.WriteLine("Папки:");
        foreach (var dir in Directory.GetDirectories(path))
            Console.WriteLine(dir);

        Console.WriteLine("\nФайли:");
        foreach (var file in Directory.GetFiles(path))
        {
            FileInfo info = new FileInfo(file);
            Console.WriteLine($"{info.Name} | {info.Length} | {info.CreationTime}");
        }
    }
}