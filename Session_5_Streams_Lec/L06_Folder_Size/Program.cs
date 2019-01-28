using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace L06_Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"..\..\..\..\Resources\06. Folder Size\TestFolder");

            long sum = 0;

            foreach (var file in directory.GetFiles())
            {
                sum += file.Length;
            }


            Console.WriteLine($"{(double)sum/1024/1024}");

        }
    }
}
