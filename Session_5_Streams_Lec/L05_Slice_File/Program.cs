using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace L05_Slice_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFiles = int.Parse(Console.ReadLine());
            using (var reader = new FileStream(@"..\..\..\..\Resources\05. Slice File\sliceMe.txt", FileMode.Open))
            {
                var partLength = Math.Ceiling((double)reader.Length / numOfFiles);
                for (int i = 1; i <= numOfFiles; i++)
                {
                    var currentFileName = $"slice-{i}.txt";
                    var currentFileTotalBytes = 0;

                    using (var writer =
                        new FileStream($"..\\..\\..\\..\\Resources\\05. Slice File\\{currentFileName}",
                            FileMode.Create))
                    {

                        while (true)
                        {
                            var buffer = new byte[4096];
                            var totalRead = reader.Read(buffer, 0, buffer.Length);

                            if (totalRead == 0)
                            {
                                break;
                            }

                            currentFileTotalBytes += totalRead;
                            writer.Write(buffer, 0, buffer.Length);

                            if (currentFileTotalBytes >= partLength)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
