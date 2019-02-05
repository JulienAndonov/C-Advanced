using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            string[] files = Directory.GetFiles(directory);

            Dictionary<string, Dictionary<string, double>> directoryStats = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                string[] splitExt = file.Split('.');
                string[] splitFileName = file.Split('\\');

                string extention = splitExt[splitExt.Length-1];
                string fileName = splitFileName[splitFileName.Length - 1];

                FileInfo fileinfo = new FileInfo(file);
                double size = fileinfo.Length/1024;

                if (!directoryStats.ContainsKey(extention))
                {
                    directoryStats[extention] = new Dictionary<string, double>();
                }
                directoryStats[extention].Add(fileName,size);
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "/report.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in directoryStats.OrderByDescending(f=>f.Value.Count).ThenBy(x=>x.Key))
                {
                    string extension = kvp.Key;

                    writer.WriteLine($".{extension}");
                    foreach (var item in kvp.Value.OrderBy(s=>s.Value))
                    {
                        string fileName = item.Key;
                        double size = item.Value;

                        writer.WriteLine($"--{fileName} - {size:f3}kb");
                    

                    }
                }

            }

        }
    }
}
