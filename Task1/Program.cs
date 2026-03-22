using System;
using System.IO;

class Program
{
    static void Main()
    {
        int lines = 0, words = 0, charsCount = 0;

        using (StreamReader sr = new StreamReader("story.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lines++;
                charsCount += line.Length;
                words += line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }

        File.WriteAllText("report.txt",
            $"Lines: {lines}\nWords: {words}\nChars: {charsCount}");

        Console.WriteLine("Готово!");
    }
}