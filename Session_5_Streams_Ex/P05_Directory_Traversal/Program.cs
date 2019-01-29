using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace P05_Directory_Traversal
{
    class FileData
    {
        public string name { get; set; }
        public int bytes { get; set; }
        
        public FileData(string name, int bytes)
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
            var directoryFiles = Directory.GetFiles(directoryPath);
            Dictionary<string, List<FileData>> fileMetadata = new Dictionary<string, List<FileData>>();

            foreach (var file in directoryFiles)
            {
                var pathData = file.Split('\\');
                var nameExtension = pathData[pathData.Length - 1].Split(".");
                var name = nameExtension[0];
                var extension = nameExtension[1];
                var bytes = file.Length;

                if (!fileMetadata.ContainsKey(extension))
                {
                    fileMetadata[extension] = new List<FileData>();
                }
                fileMetadata[extension].Add(new FileData(name, bytes));

            }



        }
    }
}
