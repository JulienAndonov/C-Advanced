using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace P06_Full_Directory_Traversal
{

    class FileData
    {
        public string name { get; set; }
        public long bytes { get; set; }

        public FileData(string name, long bytes)
        {
            this.name = name;
            this.bytes = bytes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var directoryPath = Console.ReadLine();
            var directoryFiles = Directory.GetFiles(directoryPath,"*.*",SearchOption.AllDirectories);
            Dictionary<string, List<FileData>> extensionMetadata = new Dictionary<string, List<FileData>>();

            foreach (var file in directoryFiles)
            {
                FileInfo fileinfo = new FileInfo(file);
                var name = fileinfo.Name;
                var extension = fileinfo.Extension;
                var bytes = fileinfo.Length;

                if (!extensionMetadata.ContainsKey(extension))
                {
                    extensionMetadata[extension] = new List<FileData>();
                }
                extensionMetadata[extension].Add(new FileData(name, bytes));
            }

            foreach (var extension in extensionMetadata.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{extension.Key}");
                foreach (var file in extension.Value.OrderBy(x => x.name))
                {
                    Console.WriteLine($"--{file.name} - {file.bytes / 1024}kb");
                }
            }
        }
    }
}
