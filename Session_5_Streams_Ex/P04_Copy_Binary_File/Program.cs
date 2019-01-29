using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace P04_Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileWriter = new FileStream(@"..\..\..\..\Resources\copiedFile.png", FileMode.Create))
            {
                using (var fileReader = new FileStream(@"..\..\..\..\Resources\copyMe.png", FileMode.Open))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];
                        var currentRead = fileReader.Read(buffer, 0, buffer.Length);

                        if (currentRead == 0)
                        {
                            break;
                        }

                        fileWriter.Write(buffer, 0, currentRead);
                    }
                }
            }

        }
    }
}
